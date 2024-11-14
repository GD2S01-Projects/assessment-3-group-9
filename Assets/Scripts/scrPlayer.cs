using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Ensure you have this to use the legacy Text component

public class scrPlayer : MonoBehaviour
{
    public Text logText; // Reference to a legacy Text component for displaying log messages

    private IPatient selectedPatient;

    void Start()
    {
        // Initial check to ensure logText is assigned
        if (logText != null)
        {
            Debug.Log("logText successfully assigned at Start.");
        }
        else
        {
            Debug.LogWarning("logText is null at Start. Please check the Inspector.");
        }
    }

    public void SelectPatient(IPatient patient)
    {
        selectedPatient = patient;
        DisplayPatientDetails(patient);
    }

    public void SendPatientToPractitioner(MedicalPractitioner practitioner)
    {
        if (practitioner.IsAvailable())
        {
            practitioner.AssignPatient(selectedPatient);
            logText.text = "Patient " + selectedPatient.sName + " sent to " + practitioner.sName;
            Debug.Log("Patient " + selectedPatient.sName + " sent to " + practitioner.sName);
            selectedPatient = null;
        }
        else
        {
            logText.text = practitioner.sName + " is not available.";
            Debug.Log(practitioner.sName + " is not available.");
        }
    }

    private void DisplayPatientDetails(IPatient patient)
    {
        // Logic to display patient details on the UI
        if (logText != null)
        {
            logText.text = "Displaying details for patient: " + patient.sName;
            Debug.Log("Displaying details for patient: " + patient.sName);
        }
        else
        {
            Debug.LogWarning("logText is null when trying to display patient details.");
        }
    }

    public void SendToNurse()
    {
        if (logText != null)
        {
            logText.text = "Sending patient to nurse...";
            Debug.Log("SendToNurse() called.");
        }
        else
        {
            Debug.LogWarning("logText reference is null in SendToNurse().");
        }
    }

    public void SendToDoctor()
    {
        if (logText != null)
        {
            logText.text = "Sending patient to a doctor...";
            Debug.Log("SendToDoctor() called.");
        }
        else
        {
            Debug.LogWarning("logText reference is null in SendToDoctor().");
        }
    }

    public void DismissPatient()
    {
        if (logText != null)
        {
            logText.text = "Patient dismissed.";
            Debug.Log("DismissPatient() called.");
        }
        else
        {
            Debug.LogWarning("logText reference is null in DismissPatient().");
        }
    }
}
