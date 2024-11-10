using System;
using System.Collections.Generic;
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

    public float Cash { get; private set; }
    public float UpkeepCost { get; private set; }
    public int PatientQueueCount { get; private set; } = 0;

    private List<IObserver> observers = new List<IObserver>();

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (IObserver observer in observers)
        {
            observer.UpdateObserver();
        }
    }

    public void ShiftChange()
    {
        NotifyObservers();
    }

    public void DeductUpkeepCost()
    {
        Cash -= UpkeepCost;
        if (Cash < 0)
        {
            EndGame("Insufficient funds for upkeep.");
        }
    }

    public void IncrementPatientQueue()
    {
        PatientQueueCount++;
        if (PatientQueueCount > 15)
        {
            EndGame("Too many patients in the queue.");
        }
    }

    public void DecrementPatientQueue()
    {
        if (PatientQueueCount > 0)
        {
            PatientQueueCount--;
        }
    }

    public void EndGame(string reason)
    {
        Debug.Log("Game Over: " + reason);
        // Add game-over handling logic here
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
