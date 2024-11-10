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
    public void ReceivePatient(IPatient patient)
    {
        if (patient.sCondition == "Bleeding" && specialization == "Surgery")
        {
            Debug.Log(doctorName + " successfully treated " + patient.sName + " for bleeding.");
        }
        else if (patient.sCondition == "Broken Bone" && specialization == "X-Ray")
        {
            Debug.Log(doctorName + " successfully treated " + patient.sName + " for broken bones.");
        }
        else
        {
            Debug.Log(doctorName + " cannot treat " + patient.sName + " due to specialization mismatch.");
        }
    }
}
