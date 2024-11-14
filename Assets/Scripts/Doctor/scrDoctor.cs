using UnityEngine;
using System.Collections;

namespace MedicalPractitionerNamespace
{
    public class Doctor : MedicalPractitioner
    {
        public string Specialization;
        public bool isAvailable = true;

        public Doctor(string v1, string v2)
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
            yield return new WaitForSeconds(5); // Standard treatment time
            Debug.Log(sName + " has completed treatment for patient.");
            isAvailable = true;
        }
    }
}
