using UnityEngine;
using System.Collections.Generic;

namespace MedicalPractitionerNamespace
{
    public class DoctorFactory : MedicalPractitionerFactory
    {
        private static readonly List<string> doctorNames = new List<string>
        {
            "Dr. Smith", "Dr. Johnson", "Dr. Brown", "Dr. Taylor", "Dr. Anderson",
            "Dr. Martinez", "Dr. Hernandez", "Dr. Lee", "Dr. Wilson", "Dr. Clark"
        };

        private static readonly List<string> specializations = new List<string>
        {
            "General Practitioner", "Emergency Physician", "Cardiologist ", "Orthopedic Surgeon",
            "Dermatology"
        };

        public Doctor CreateRandomDoctor()
        {
            // Randomly select a name and specialization for the doctor
            string name = doctorNames[Random.Range(0, doctorNames.Count)];
            string specialization = specializations[Random.Range(0, specializations.Count)];

            // Create the doctor GameObject and component
            GameObject doctorObject = new GameObject(name);
            Doctor doctor = doctorObject.AddComponent<Doctor>();
            doctor.sName = name;
            doctor.Specialization = specialization;
            doctor.isAvailable = true;

            Debug.Log($"Created Doctor: {name} with specialization in {specialization}");

            return doctor;
        }

        public override MedicalPractitioner CreateMedicalPractitioner()
        {
            return CreateRandomDoctor();
        }
    }
}
