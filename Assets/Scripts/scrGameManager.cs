using System;
using System.Collections.Generic;
using UnityEngine;
using MedicalPractitionerNamespace;

public class GameManager : MonoBehaviour
{
    float fGameTimer = 0.0f;
    float fUpkeepTimeInterval = 180.0f;

    int iMoney = 0;
    int iUpkeep = 500;
    int iUpkeepInterval = 50;
    public static GameManager Instance; 

    public HospitalController hospitalController;
    private float fPatientSpawnInterval = 10.0f;
    private int iSpawnIntervalCounter = 0;

    private int iCuredPatientReward = 100;

    public float Cash { get; private set; }
    public float UpkeepCost { get; private set; }
    public int PatientQueueCount { get; private set; } = 0;

    private List<IObserver> observers = new List<IObserver>();

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        // Create a nurse and a doctor
        Nurse nurse = new Nurse("Sarah");
        scrDoctor surgeon = new scrDoctor("Dr. Smith", "Surgery");
        hospitalController = GetComponent<HospitalController>();

        // Creates a nurse and a doctor using AddComponent
        Nurse nurse = gameObject.AddComponent<Nurse>();
        nurse.sName = "Sarah";

        Doctor surgeon = gameObject.AddComponent<Doctor>();
        surgeon.sName = "Dr. Smith";
        surgeon.Specialization = "Surgery";
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
