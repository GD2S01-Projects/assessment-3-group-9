using UnityEngine;

public class GameManager : MonoBehaviour
{
    float fGameTimer = 0.0f;
    float fUpkeepTimeInterval = 180.0f;

    int iMoney = 0;
    int iUpkeep = 500;
    int iUpkeepInterval = 50;

    
    void Start()
    {
        // Create a nurse and a doctor
        Nurse nurse = new Nurse("Sarah");
        scrDoctor surgeon = new scrDoctor("Dr. Smith", "Surgery");

        // Assign doctor to nurse
        nurse.AssignDoctor(surgeon);

        // Create a patient with a condition
        IPatient patient1 = new cAdultPatient();

        // Simulate calling, testing, and diagnosing the patient
        nurse.CallPatient(patient1);

        // The nurse tests the patient with a thermometer
        nurse.TestPatient("thermometer");

        // The nurse tests the patient with a stethoscope
        nurse.TestPatient("stethoscope");

        // Display nurse's score after interaction
        nurse.DisplayScore();
    }

    private void Update()
    {
        fGameTimer += Time.deltaTime;

        if (fGameTimer > fUpkeepTimeInterval)
        {
            fGameTimer = 0.0f;
            iMoney -= iUpkeep;

            if (iMoney < 0)
            {
                Debug.Log("You couldn't pay your staff and the hospital grinds to a stop. You lose!");
                Application.Quit();
            }
            else
            {
                iUpkeep += iUpkeepInterval;
            }
        }
    }
}
