using UnityEngine;

public class scrDoctor
{
    public string doctorName;
    public string specialization;

    // Constructor for the doctor
    public scrDoctor(string name, string specialization)
    {
        this.doctorName = name;
        this.specialization = specialization;
    }

    // Method to receive a patient and provide feedback based on specialization
    public void ReceivePatient(scrPatient patient)
    {
        if (patient.patientBodyCondition == "Bleeding" && specialization == "Surgery")
        {
            Debug.Log(doctorName + " successfully treated " + patient.patientName + " for bleeding.");
        }
        else if (patient.patientBodyCondition == "Broken Bone" && specialization == "X-Ray")
        {
            Debug.Log(doctorName + " successfully treated " + patient.patientName + " for broken bones.");
        }
        else
        {
            Debug.Log(doctorName + " cannot treat " + patient.patientName + " due to specialization mismatch.");
        }
    }
}
