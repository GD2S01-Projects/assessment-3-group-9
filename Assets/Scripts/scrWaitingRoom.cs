using System.Collections.Generic;
using UnityEngine;

public class WaitingRoom : MonoBehaviour, IObserver
{
    private List<GameObject> patients = new List<GameObject>();

    public void AddPatientToRoom(GameObject patient)
    {
        if (patients.Count < 15)
        {
            patients.Add(patient);
            Debug.Log("Patient added to the waiting room.");
        }
        else
        {
            GameManager.Instance.IncrementPatientQueue();
            Debug.Log("Waiting room full, patient added to queue.");
        }
        GameManager.Instance.NotifyObservers();
    }

    public void RemovePatientFromRoom(GameObject patient)
    {
        if (patients.Contains(patient))
        {
            patients.Remove(patient);
            Debug.Log("Patient removed from the waiting room.");
            GameManager.Instance.DecrementPatientQueue();
            GameManager.Instance.NotifyObservers();
        }
    }

    public bool HasPatient()
    {
        return patients.Count > 0;
    }

    public void UpdateObserver()
    {
        Debug.Log("Waiting room has been notified of a game state change.");
    }
}
