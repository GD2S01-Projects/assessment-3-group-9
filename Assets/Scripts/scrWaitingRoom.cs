using System.Collections.Generic;
using UnityEngine;

public class WaitingRoom : MonoBehaviour, IObserver
{
    private List<IPatient> PatientsList = new List<IPatient>();

    private float fWaitingRoomTimer = 0.0f;
    private float fPatientAdmitInterval = 10.0f;

    private void Update()
    {
        fWaitingRoomTimer += Time.deltaTime;
        if (fWaitingRoomTimer > fPatientAdmitInterval)
        {
            AdmitPatient();
            fWaitingRoomTimer= 0.0f;
        }
    }

    public void AdmitPatient()
    {
        cAdultPatientFactory adultPatientFactory = new cAdultPatientFactory();
        cChildPatientFactory childPatientFactory = new cChildPatientFactory();

        int iCoinFlip = Random.Range(0, 2);

        // Create Child Patient
        if (iCoinFlip == 0)
        {
            IPatient newChildPatient = childPatientFactory.CreatePatient();
            AddPatientToRoom(newChildPatient);
        }
        // Create Adult Patient
        else if (iCoinFlip == 1)
        {
            IPatient newAdultPatient = adultPatientFactory.CreatePatient();
            AddPatientToRoom(newAdultPatient);
        }
    }

    public void AddPatientToRoom(IPatient patient)
    {
        GameManager.Instance.IncrementPatientQueue();
        scrUIManager.Instance.OnNewPatient(patient);
        PatientsList.Add(patient);
        Debug.Log("Patient added to the waiting room.");
        GameManager.Instance.NotifyObservers();
    }

    public void RemovePatientFromRoom(IPatient patient)
    {
        if (PatientsList.Contains(patient))
        {
            PatientsList.Remove(patient);
            Debug.Log("Patient removed from the waiting room.");
            GameManager.Instance.DecrementPatientQueue();
            GameManager.Instance.NotifyObservers();
        }
    }

    public bool HasPatient()
    {
        return PatientsList.Count > 0;
    }

    public void UpdateObserver()
    {
        Debug.Log("Waiting room has been notified of a game state change.");
    }
}
