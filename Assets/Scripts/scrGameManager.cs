using UnityEngine;

public class GameManager : MonoBehaviour
{
    public HospitalController hospitalController;
    float fGameTimer = 0.0f;
    float fPatientSpawnInterval = 10.0f;
    int iSpawnIntervalCounter = 0;

    int iMoney = 0;
    int iUpkeep = 500;
    int iUpkeepInterval = 250;
    int iCuredPatientReward = 100; 

    
    void Start()
    {
        hospitalController = GetComponent<HospitalController>();
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

        if (fGameTimer > (fPatientSpawnInterval * iSpawnIntervalCounter))
        {
            if (iSpawnIntervalCounter == 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    hospitalController.AdmitPatient();
                }
            }
            else
            {
                hospitalController.AdmitPatient();
            }
        }
    }
}
