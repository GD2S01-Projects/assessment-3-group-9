using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;

public class scrUIManager : MonoBehaviour
{
    public static scrUIManager Instance { get; private set; }

    [Header("Main Controllers")]
    public HospitalController hospitalController;

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
    public TextMeshProUGUI patientHeadConditionText;
    public TextMeshProUGUI patientBodyConditionText;
    public TextMeshProUGUI patientLeftArmConditionText;
    public TextMeshProUGUI patientRightArmConditionText;
    public TextMeshProUGUI patientLeftLegConditionText;
    public TextMeshProUGUI patientRightLegConditionText;

    [Header("Prefabs")]
    public GameObject patientIndicatorPrefab;
    public GameObject roomIndicatorPrefab;
    public GameObject logEntryPrefab;

    private Dictionary<string, scrPatientIndicator> patientIndicators = new Dictionary<string, scrPatientIndicator>();
    private Dictionary<string, scrRoomIndicator> doctorRoomIndicators = new Dictionary<string, scrRoomIndicator>();
    private Dictionary<string, scrRoomIndicator> nurseRoomIndicators = new Dictionary<string, scrRoomIndicator>();

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        InitializeUI();
    }

    private void InitializeUI()
    {
        ClearAllContainers();
        CreateDoctorRooms();
        CreateNurseRooms();
        patientInfoPanel.SetActive(false);
    }

    public void OnNewPatient(IPatient patient)
    {
        GameObject indicator = Instantiate(patientIndicatorPrefab, patientGridContainer);
        scrPatientIndicator patientIndicator = indicator.GetComponent<scrPatientIndicator>();
        patientIndicator.Initialize(patient);
        // patientIndicators[patient.GetInstanceID().ToString()] = patientIndicator;
        UpdatePatientCounter();
        AddLogEntry($"New patient has arrived at the hospital");
    }

    public void ShowPatientInfo(IPatient patient)
    {
        patientHeadConditionText.text = $"Head: {patient.DescribeSymptoms()}";
        patientBodyConditionText.text = $"Body: {patient.DescribeSymptoms()}";
        patientLeftArmConditionText.text = $"Left Arm: {patient.DescribeSymptoms()}";
        patientRightArmConditionText.text = $"Right Arm: {patient.DescribeSymptoms()}";
        patientLeftLegConditionText.text = $"Left Leg: {patient.DescribeSymptoms()}";
        patientRightLegConditionText.text = $"Right Leg: {patient.DescribeSymptoms()}";
        patientInfoPanel.SetActive(true);
        AddLogEntry($"Examining patient");
    }

    private void CreateDoctorRooms()
    {
        for (int i = 0; i < 6; i++)
        {
            GameObject roomObj = Instantiate(roomIndicatorPrefab, doctorRoomsContainer);
            scrRoomIndicator room = roomObj.GetComponent<scrRoomIndicator>();
            room.Initialize($"Doctor_{i}");
            doctorRoomIndicators[room.GetRoomId()] = room;
        }
    }

    private void CreateNurseRooms()
    {
        for (int i = 0; i < 6; i++)
        {
            GameObject roomObj = Instantiate(roomIndicatorPrefab, nurseRoomContainer);
            scrRoomIndicator room = roomObj.GetComponent<scrRoomIndicator>();
            room.Initialize($"Nurse_{i}");
            nurseRoomIndicators[room.GetRoomId()] = room;
        }
    }

    public void UpdateRoomStatus(string roomId, bool isOccupied)
    {
        if (doctorRoomIndicators.TryGetValue(roomId, out scrRoomIndicator doctorRoom))
        {
            doctorRoom.SetOccupied(isOccupied);
        }
        else if (nurseRoomIndicators.TryGetValue(roomId, out scrRoomIndicator nurseRoom))
        {
            nurseRoom.SetOccupied(isOccupied);
        }
    }

    private void UpdatePatientCounter()
    {
        patientCounterText.text = $"Patients: {patientIndicators.Count}";
    }

    public void AddLogEntry(string message)
    {
        GameObject entryObj = Instantiate(logEntryPrefab, logContainer);
        scrLogEntry logEntry = entryObj.GetComponent<scrLogEntry>();
        logEntry.Initialize(System.DateTime.Now.ToString("HH:mm:ss"), message);
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