using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;
using System;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }

    [Header("Prefabs")]
    public GameObject patientIndicatorPrefab;
    public GameObject roomIndicatorPrefab;
    public GameObject logEntryPrefab;

    [Header("UI Containers")]
    public Transform patientGridContainer;
    public Transform doctorRoomsContainer;
    public Transform nurseRoomContainer;
    public Transform logContainer;
    public ScrollRect logScrollRect;

    [Header("UI Text Elements")]
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI cashText;
    public TextMeshProUGUI upkeepText;
    public TextMeshProUGUI patientCounterText;

    [Header("Patient Info Panel")]
    public GameObject patientInfoPanel;
    public TextMeshProUGUI patientNameText;
    public TextMeshProUGUI patientAgeText;
    public TextMeshProUGUI patientConditionText;

    private Dictionary<string, PatientIndicator> patientIndicators = new Dictionary<string, PatientIndicator>();
    private Dictionary<string, RoomIndicator> doctorRoomIndicators = new Dictionary<string, RoomIndicator>();
    private Dictionary<string, RoomIndicator> nurseRoomIndicators = new Dictionary<string, RoomIndicator>();

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        InitializeUI();
        // Subscribe to GameManager events
        scrGameManager.Instance.OnCashChanged += UpdateCashDisplay;
        scrGameManager.Instance.OnTimeChanged += UpdateTimeDisplay;
        scrGameManager.Instance.OnUpkeepChanged += UpdateUpkeepDisplay;
    }

    private void InitializeUI()
    {
        // Clear any existing indicators
        ClearAllContainers();

        // Initialize with doctors from factory
        foreach (var doctor in DoctorFactory.Instance.GetAllDoctors())
        {
            CreateDoctorRoomIndicator(doctor.id);
        }

        // Initialize with nurses from factory
        foreach (var nurse in NurseFactory.Instance.GetAllNurses())
        {
            CreateNurseRoomIndicator(nurse.id);
        }

        patientInfoPanel.SetActive(false);
    }

    public void OnNewPatient(string patientId, string patientName)
    {
        CreatePatientIndicator(patientId);
        UpdatePatientCounter();
        AddLogEntry($"New patient arrived: {patientName}");
    }

    public void OnPatientAssignedToDoctor(string patientId, string doctorId, string patientName, string doctorName)
    {
        if (doctorRoomIndicators.TryGetValue(doctorId, out RoomIndicator room))
        {
            room.SetOccupied(true);
        }
        AddLogEntry($"Patient {patientName} is seeing Dr. {doctorName}");
    }

    public void OnPatientAssignedToNurse(string patientId, string nurseId, string patientName, string nurseName)
    {
        if (nurseRoomIndicators.TryGetValue(nurseId, out RoomIndicator room))
        {
            room.SetOccupied(true);
        }
        AddLogEntry($"Patient {patientName} is seeing Nurse {nurseName}");
    }

    public void OnPatientDismissed(string patientId, string patientName, string reason)
    {
        if (patientIndicators.TryGetValue(patientId, out PatientIndicator indicator))
        {
            Destroy(indicator.gameObject);
            patientIndicators.Remove(patientId);
        }
        UpdatePatientCounter();
        AddLogEntry($"Patient {patientName} has left: {reason}");
    }

    public void OnCashTransaction(float amount, string reason)
    {
        string prefix = amount >= 0 ? "+" : "-";
        AddLogEntry($"{prefix}${Mathf.Abs(amount):F2} - {reason}");
    }

    public void ShowPatientInfo(string patientId)
    {
        // Pull patient data from your patient management system
        var patient = PatientFactory.Instance.GetPatient(patientId);
        if (patient != null)
        {
            patientNameText.text = patient.name;
            patientAgeText.text = patient.age.ToString();
            patientConditionText.text = patient.condition;
            patientInfoPanel.SetActive(true);
            AddLogEntry($"Viewing patient info: {patient.name}");
        }
    }

    private void UpdateCashDisplay(float newAmount)
    {
        cashText.text = $"${newAmount:F2}";
    }

    private void UpdateTimeDisplay(string timeString)
    {
        timerText.text = timeString;
    }

    private void UpdateUpkeepDisplay(float upkeepAmount)
    {
        upkeepText.text = $"Upkeep: ${upkeepAmount}/hr";
    }

    private void UpdatePatientCounter()
    {
        int count = patientIndicators.Count;
        patientCounterText.text = $"Patients: {count}";
    }

    private void AddLogEntry(string message)
    {
        GameObject entryObject = Instantiate(logEntryPrefab, logContainer);
        LogEntry entry = entryObject.GetComponent<LogEntry>();
        entry.Initialize(System.DateTime.Now.ToString("HH:mm:ss"), message);

        // Auto scroll to bottom
        Canvas.ForceUpdateCanvases();
        logScrollRect.normalizedPosition = new Vector2(0, 0);
    }

    private void ClearAllContainers()
    {
        foreach (Transform child in patientGridContainer) Destroy(child.gameObject);
        foreach (Transform child in doctorRoomsContainer) Destroy(child.gameObject);
        foreach (Transform child in nurseRoomContainer) Destroy(child.gameObject);
        patientIndicators.Clear();
        doctorRoomIndicators.Clear();
        nurseRoomIndicators.Clear();
    }
}