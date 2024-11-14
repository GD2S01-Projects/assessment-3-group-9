using UnityEngine;
using System.Collections;

namespace MedicalPractitionerNamespace
{
    public class Nurse : MedicalPractitioner
    {
        public int EfficiencyLevel = 1;
        public bool isAvailable = true;

        public Nurse(string v)
        {
        }

        public override bool IsAvailable() => isAvailable;

        public override void AssignPatient(GameObject patient)
        {
            if (isAvailable)
            {
                Debug.Log(sName + " is treating patient: " + patient.name);
                isAvailable = false;
                StartCoroutine(CompleteTreatment());
            }
            else
            {
                Debug.Log(sName + " is currently busy.");
            }
        }

        private IEnumerator CompleteTreatment()
        {
            yield return new WaitForSeconds(5 / EfficiencyLevel); // Adjusted treatment time
            Debug.Log(sName + " has completed treatment for patient.");
            isAvailable = true;
        }
    }
}
