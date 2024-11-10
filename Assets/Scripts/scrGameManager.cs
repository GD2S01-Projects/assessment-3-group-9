using System;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
                if (instance == null)
                {
                    GameObject go = new GameObject("GameManager");
                    instance = go.AddComponent<GameManager>();
                }
            }
            return instance;
        }
    }

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
}
