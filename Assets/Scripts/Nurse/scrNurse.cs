using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Nurse : MonoBehaviour
{
    public string nurseName;
    public int efficiencyLevel = 1;
    public int score = 0;

    public Text patientInfoText;  // Default Unity UI Text component for patient info
    public Text feedbackText;     // Default Unity UI Text component for feedback
    public InputField diagnosisInputField; // Input field for nurse to enter diagnosis
    public Button thermometerButton;  // Button for thermometer test
    public Button stethoscopeButton;  // Button for stethoscope test
    public Button confirmDiagnosisButton; // Button to confirm diagnosis

    private IPatient currentPatient;
    private scrDoctor specialistDoctor;

    // Diagnostic tools with cooldowns
    private bool thermometerReady = true;
    private bool stethoscopeReady = true;

    // Tool cooldown durations
    private float toolCooldownTime = 5f;

    // Constructor for the nurse
    public Nurse(string name)
    {
        this.nurseName = name;
    }

    private void Start()
    {
        // Assign button listeners
        thermometerButton.onClick.AddListener(() => TestPatient("thermometer"));
        stethoscopeButton.onClick.AddListener(() => TestPatient("stethoscope"));
        confirmDiagnosisButton.onClick.AddListener(ConfirmDiagnosis);
    }

    // Assign a specialist doctor for referrals
    public void AssignDoctor(scrDoctor doctor)
    {
        specialistDoctor = doctor;
    }

    // Call a new patient for diagnosis
    public void CallPatient(IPatient newPatient)
    {
        currentPatient = newPatient;
        patientInfoText.text = "Patient: " + currentPatient.sName +
            "\nCurrent Symptoms: " + currentPatient.DescribeSymptoms();
    }

    // Test a patient with a tool
    public void TestPatient(string tool)
    {
        if (currentPatient == null)
        {
            feedbackText.text = "No patient to test.";
            Debug.Log("No patient to test.");  // Log check
            return;
        }

        Debug.Log("Testing patient with " + tool);  // Log the tool being used

        switch (tool.ToLower())
        {
            case "thermometer":
                if (thermometerReady)
                {
                    feedbackText.text = "Testing with the thermometer... Normal temperature.";
                    Debug.Log("Thermometer used");  // Log check
                    StartCoroutine(ToolCooldown("thermometer"));
                }
                else
                {
                    feedbackText.text = "Thermometer is cooling down.";
                    Debug.Log("Thermometer is cooling down");  // Log check
                }
                break;

            case "stethoscope":
                if (stethoscopeReady)
                {
                    feedbackText.text = "Testing with the stethoscope... Heart rate is elevated.";
                    Debug.Log("Stethoscope used");  // Log check
                    StartCoroutine(ToolCooldown("stethoscope"));
                }
                else
                {
                    feedbackText.text = "Stethoscope is cooling down.";
                    Debug.Log("Stethoscope is cooling down");  // Log check
                }
                break;

            default:
                feedbackText.text = "Invalid tool.";
                Debug.Log("Invalid tool selected");  // Log check
                break;
        }
    }
    // Confirm the diagnosis based on patient tests
    public void ConfirmDiagnosis()
    {
        if (currentPatient == null)
        {
            feedbackText.text = "No patient assigned for diagnosis.";
            Debug.Log("No patient assigned for diagnosis.");  // Log check
            return;
        }

        string nurseDiagnosis = diagnosisInputField.text;
        Debug.Log("Diagnosis entered: " + nurseDiagnosis);  // Log the entered diagnosis

        bool isCorrect = Diagnosis.ConfirmDiagnosis(currentPatient.sCondition, nurseDiagnosis);
        if (isCorrect)
        {
            score += 10 * efficiencyLevel;
            feedbackText.text = "Correct diagnosis! Score: " + score;
            Debug.Log("Correct diagnosis. Updated score: " + score);  // Log correct diagnosis
        }
        else
        {
            score -= 5;
            feedbackText.text = "Incorrect diagnosis. Score: " + score;
            Debug.Log("Incorrect diagnosis. Updated score: " + score);  // Log incorrect diagnosis
        }
    }


    // Refer the patient to a specialist doctor
    public void ReferToDoctor(IPatient patient)
    {
        if (specialistDoctor != null)
        {
            specialistDoctor.ReceivePatient(patient);
        }
        else
        {
            feedbackText.text = "No specialist doctor assigned.";
        }
    }

    // Coroutine to handle tool cooldowns
    private IEnumerator ToolCooldown(string tool)
    {
        switch (tool)
        {
            case "thermometer":
                thermometerReady = false;
                yield return new WaitForSeconds(toolCooldownTime);
                thermometerReady = true;
                feedbackText.text = "Thermometer is ready to use again.";
                break;

            case "stethoscope":
                stethoscopeReady = false;
                yield return new WaitForSeconds(toolCooldownTime);
                stethoscopeReady = true;
                feedbackText.text = "Stethoscope is ready to use again.";
                break;
        }
    }

    // Display current score
    public void DisplayScore()
    {
        Debug.Log(nurseName + " has a current score of: " + score);
    }
}

