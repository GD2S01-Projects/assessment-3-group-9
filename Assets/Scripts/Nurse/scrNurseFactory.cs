using UnityEngine;

namespace MedicalPractitionerNamespace
{
    public class NurseFactory : MedicalPractitionerFactory
    {
        public Nurse CreateNurse(string name, int efficiencyLevel)
        {
            // Creates a new GameObject for the Nurse
            GameObject nurseObject = new GameObject(name);

            // Adds the Nurse component to the GameObject
            Nurse nurse = nurseObject.AddComponent<Nurse>();
            nurse.sName = name;
            nurse.EfficiencyLevel = efficiencyLevel;
            nurse.isAvailable = true;

            Debug.Log("Created Nurse: " + name + " with efficiency level " + efficiencyLevel);

            return nurse;
        }

        public override MedicalPractitioner CreateMedicalPractitioner()
        {
            // Default nurse creation with placeholder values
            return CreateNurse("Default Nurse", 1);
        }
    }
}
