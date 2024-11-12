using UnityEngine;

namespace MedicalPractitionerNamespace
{
    public class DoctorFactory : MedicalPractitionerFactory
    {
        public Doctor CreateDoctor(string name, string specialization)
        {
            // Creates a new GameObject for the Doctor
            GameObject doctorObject = new GameObject(name);

            // Adds the Doctor component to the GameObject
            Doctor doctor = doctorObject.AddComponent<Doctor>();
            doctor.sName = name;
            doctor.Specialization = specialization;
            doctor.isAvailable = true;

            Debug.Log("Created Doctor: " + name + " specialized in " + specialization);

            return doctor;
        }

        public override MedicalPractitioner CreateMedicalPractitioner()
        {
            // Default doctor creation with placeholder values
            return CreateDoctor("Default Doctor", "General");
        }
    }
}
