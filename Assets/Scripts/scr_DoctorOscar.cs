using UnityEngine;

public class Doctor
{
    public string doctorName;
    public string specialization;

    // Constructor for the doctor
    public Doctor(string name, string specialization)
    {
        this.doctorName = name;
        this.specialization = specialization;
    }

    // Method to receive a patient and provide feedback based on specialization
    public void ReceivePatient(Patient patient)
    {
        if (patient.condition == "Bleeding" && specialization == "Surgery")
        {
            Debug.Log(doctorName + " successfully treated " + patient.patientName + " for bleeding.");
        }
        else if (patient.condition == "Broken Bones" && specialization == "X-Ray")
        {
            Debug.Log(doctorName + " successfully treated " + patient.patientName + " for broken bones.");
        }
        else
        {
            Debug.Log(doctorName + " cannot treat " + patient.patientName + " due to specialization mismatch.");
        }
    }
}
