using System.Collections;
using UnityEngine;

public class Nurse : MonoBehaviour
{
    public string nurseName;
    public int efficiencyLevel = 1;
    public int score = 0;

    private Patient currentPatient;
    private Doctor specialistDoctor;

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

    // Assign a specialist doctor for referrals
    public void AssignDoctor(Doctor doctor)
    {
        specialistDoctor = doctor;
    }

    // Call a new patient for diagnosis
    public void CallPatient(Patient newPatient)
    {
        currentPatient = newPatient;
        Debug.Log(nurseName + " has called in " + currentPatient.patientName + ". Symptoms: " + currentPatient.DescribeSymptoms());
    }

    // Test a patient with a tool
    public void TestPatient(string tool)
    {
        if (currentPatient == null)
        {
            Debug.Log("No patient to test.");
            return;
        }

        switch (tool.ToLower())
        {
            case "thermometer":
                if (thermometerReady)
                {
                    Debug.Log("Testing " + currentPatient.patientName + " with the thermometer.");
                    Debug.Log("Temperature is normal.");
                    StartCoroutine(ToolCooldown("thermometer"));
                }
                else
                {
                    Debug.Log("Thermometer is still cooling down.");
                }
                break;

            case "stethoscope":
                if (stethoscopeReady)
                {
                    Debug.Log("Testing " + currentPatient.patientName + " with the stethoscope.");
                    Debug.Log("Heart rate is elevated.");
                    StartCoroutine(ToolCooldown("stethoscope"));
                }
                else
                {
                    Debug.Log("Stethoscope is still cooling down.");
                }
                break;

            default:
                Debug.Log("Invalid tool selected.");
                break;
        }
    }

    // Confirm the diagnosis based on patient tests
    public void ConfirmDiagnosis(string nurseDiagnosis)
    {
        if (currentPatient != null)
        {
            bool isCorrect = Diagnosis.ConfirmDiagnosis(currentPatient.condition, nurseDiagnosis);
            if (isCorrect)
            {
                score += 10 * efficiencyLevel;
                Debug.Log("Correct diagnosis. Score updated to " + score);
            }
            else
            {
                score -= 5;
                Debug.Log("Incorrect diagnosis. Score updated to " + score);
            }

            // Refer to a specialist doctor if needed
            if (currentPatient.needsSpecialist)
            {
                ReferToDoctor(currentPatient);
            }
        }
        else
        {
            Debug.Log("No patient assigned for diagnosis.");
        }
    }

    // Refer the patient to a specialist doctor
    public void ReferToDoctor(Patient patient)
    {
        if (specialistDoctor != null)
        {
            specialistDoctor.ReceivePatient(patient);
        }
        else
        {
            Debug.Log("No specialist doctor assigned.");
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
                Debug.Log("Thermometer is ready to use again.");
                break;

            case "stethoscope":
                stethoscopeReady = false;
                yield return new WaitForSeconds(toolCooldownTime);
                stethoscopeReady = true;
                Debug.Log("Stethoscope is ready to use again.");
                break;
        }
    }

    // Display current score
    public void DisplayScore()
    {
        Debug.Log(nurseName + " has a current score of: " + score);
    }
}
