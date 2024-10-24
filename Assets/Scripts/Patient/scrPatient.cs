using UnityEngine;

public class scrPatient : MonoBehaviour
{
    public string patientName;
    public string condition;
    public bool needsSpecialist;

    // Constructor to create a patient with a condition
    public scrPatient(string name, string condition, bool needsSpecialist)
    {
        this.patientName = name;
        this.condition = condition;
        this.needsSpecialist = needsSpecialist;
    }

    // Method to describe symptoms
    public string DescribeSymptoms()
    {
        switch (condition)
        {
            case "Bleeding":
                return "The patient is bleeding heavily.";
            case "Bruised":
                return "The patient has multiple bruises.";
            case "Frostbite":
                return "The patient's skin is pale and frozen.";
            default:
                return "The patient looks generally unwell.";
        }
    }
}
