using UnityEngine;

public abstract class MedicalPractitioner : MonoBehaviour
{
    public string sName { get; set; }
    public string sOccupation { get; set; }

    public abstract bool IsAvailable();
    public abstract void AssignPatient(GameObject patient);
}
