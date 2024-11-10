using UnityEngine;
using MedicalPractitionerNamespace; // Add this to access Doctor

public class DoctorFactory : MedicalPractitionerFactory
{
    public override MedicalPractitioner CreateMedicalPractitioner()
    {
        GameObject doctorObject = new GameObject("Doctor");
        Doctor doctor = doctorObject.AddComponent<Doctor>(); // Ensure the namespace matches
        return doctor;
    }
}
