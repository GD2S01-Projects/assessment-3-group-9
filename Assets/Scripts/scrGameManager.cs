using System;
using System.Collections.Generic;
using UnityEngine;
using MedicalPractitionerNamespace;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; 

    public HospitalController hospitalController;
    private float fGameTimer = 0.0f;
    private float fUpkeepTimeInterval = 180.0f;

    private int iMoney = 0;
    private int iUpkeep = 500;
    private int iUpkeepInterval = 50;

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
        hospitalController = GetComponent<HospitalController>();

        // Creates a nurse and a doctor using AddComponent
        Nurse nurse = new Nurse();
        nurse.sName = "Sarah";
        nurse.EfficiencyLevel = 1;

        Doctor surgeon = new Doctor();
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
        iMoney -= iUpkeep;
        if (iMoney < 0)
        {
            EndGame("Insufficient funds for upkeep.");
        }
        else
        {
            ShiftChange();
            iUpkeep += iUpkeepInterval;
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
            DeductUpkeepCost();            
        }
    }
}
