using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        // Create a nurse and a doctor
        Nurse nurse = new Nurse("Sarah");
        scrDoctor surgeon = new scrDoctor("Dr. Smith", "Surgery");

        // Assign doctor to nurse
        nurse.AssignDoctor(surgeon);

        // Create a patient with a condition
        scrPatient patient1 = new scrPatient();

        // Simulate calling, testing, and diagnosing the patient
        nurse.CallPatient(patient1);

        // The nurse tests the patient with a thermometer
        nurse.TestPatient("thermometer");

        // The nurse tests the patient with a stethoscope
        nurse.TestPatient("stethoscope");

        // Display nurse's score after interaction
        nurse.DisplayScore();
    }
}
