using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum PatientIncidents
{
    CarCrash,
    MountainAccident,
    Attacked,
    Fight,
    Exposed,
    FellOver,
    WorkAccident
}

public abstract class cPatientFactory
{
    public abstract IPatient CreatePatient();

    public void SetPatientVariables(IPatient _patient)
    {
        _patient.sName = RandomisePatientName();
        PatientIncidents randomIncident = (PatientIncidents)Random.Range(0, System.Enum.GetValues(typeof(PatientIncidents)).Length);
        switch(randomIncident)
        {
            case PatientIncidents.CarCrash:
                {
                    _patient.sCondition = RandomiseIncidentCondition(PatientIncidents.CarCrash);
                    _patient.iHealth = RandomiseIncidentState(PatientIncidents.CarCrash);
                    _patient.sAccidentInfo = "CarCrash";
                    break;
                }
            case PatientIncidents.MountainAccident:
                {
                    _patient.sCondition = RandomiseIncidentCondition(PatientIncidents.MountainAccident);
                    _patient.iHealth = RandomiseIncidentState(PatientIncidents.MountainAccident);
                    _patient.sAccidentInfo = "MountainAccident";
                    break;
                }
            case PatientIncidents.Attacked:
                {
                    _patient.sCondition = RandomiseIncidentCondition(PatientIncidents.Attacked);
                    _patient.iHealth = RandomiseIncidentState(PatientIncidents.Attacked);
                    _patient.sAccidentInfo = "Attacked";
                    break;
                }
            case PatientIncidents.Fight:
                {
                    _patient.sCondition = RandomiseIncidentCondition(PatientIncidents.Fight);
                    _patient.iHealth = RandomiseIncidentState(PatientIncidents.Fight);
                    _patient.sAccidentInfo = "Fight";
                    break;
                }
            case PatientIncidents.Exposed:
                {
                    _patient.sCondition = RandomiseIncidentCondition(PatientIncidents.Exposed);
                    _patient.iHealth = RandomiseIncidentState(PatientIncidents.Exposed);
                    _patient.sAccidentInfo = "Exposed";
                    break;
                }
            case PatientIncidents.FellOver:
                {
                    _patient.sCondition = RandomiseIncidentCondition(PatientIncidents.FellOver);
                    _patient.iHealth = RandomiseIncidentState(PatientIncidents.FellOver);
                    _patient.sAccidentInfo = "FellOver";
                    break;
                }
            case PatientIncidents.WorkAccident:
                {
                    _patient.sCondition = RandomiseIncidentCondition(PatientIncidents.WorkAccident);
                    _patient.iHealth = RandomiseIncidentState(PatientIncidents.WorkAccident);
                    _patient.sAccidentInfo = "WorkAccident";
                    break;
                }
        }
    }

    public string RandomisePatientName()
    {
        int selectedName = Random.Range(0, 20);

        switch (selectedName)
        {
            case 0:
                {
                    return "Ethan";
                }
            case 1:
                {
                    return "Leo";
                }
            case 2:
                {
                    return "Marcus";
                }
            case 3:
                {
                    return "Julian";
                }
            case 4:
                {
                    return "Asher";
                }
            case 5:
                {
                    return "Lucas";
                }
            case 6:
                {
                    return "Kai";
                }
            case 7:
                {
                    return "Elias";
                }
            case 8:
                {
                    return "Adrian";
                }
            case 9:
                {
                    return "Damon";
                }
            case 10:
                {
                    return "Mia";
                }
            case 11:
                {
                    return "Clara";
                }
            case 12:
                {
                    return "Nora";
                }
            case 13:
                {
                    return "Ivy";
                }
            case 14:
                {
                    return "Aria";
                }
            case 15:
                {
                    return "Layla";
                }
            case 16:
                {
                    return "Zoe";
                }
            case 17:
                {
                    return "Elise";
                }
            case 18:
                {
                    return "Luna";
                }
            case 19:
                {
                    return "Vera";
                }
            default: return "Freddy Fazbear";
        }
    }

    private string RandomiseIncidentCondition(PatientIncidents Incident)
    {
        string newCondition = "Healthy";
        switch (Incident)
        {
            case PatientIncidents.CarCrash:
                {
                    int randomCounter = Random.Range(0, 4);
                    switch (randomCounter)
                    {
                        case 0: newCondition = "Bleeding"; break;
                        case 1: newCondition = "Healthy"; break;
                        case 2: newCondition = "BrokenBone"; break;
                        case 3: newCondition = "HighBPM"; break;
                        default: newCondition = "Bleeding"; break;
                    }
                    break;
                }
            case PatientIncidents.MountainAccident:
                {
                    int randomCounter = Random.Range(0, 4);
                    switch (randomCounter)
                    {
                        case 0: newCondition = "Bleeding"; break;
                        case 1: newCondition = "Sick"; break;
                        case 2: newCondition = "BrokenBone"; break;
                        case 3: newCondition = "Healthy"; break;
                        default: newCondition = "Bleeding"; break;
                    }
                    break;
                }
            case PatientIncidents.Attacked:
                {
                    int randomCounter = Random.Range(0, 3);
                    switch (randomCounter)
                    {
                        case 0: newCondition = "Bleeding"; break;
                        case 1: newCondition = "HeartAttack"; break;
                        case 2: newCondition = "Healthy"; break;
                        default: newCondition = "Bleeding"; break;
                    }
                    break;
                }
            case PatientIncidents.Fight:
                {
                    int randomCounter = Random.Range(0, 2);
                    switch (randomCounter)
                    {
                        case 0: newCondition = "Bleeding"; break;
                        case 1: newCondition = "Healthy"; break;
                        default: newCondition = "Bleeding"; break;
                    }
                    break;
                }
            case PatientIncidents.Exposed:
                {
                    int randomCounter = Random.Range(0, 3);
                    switch (randomCounter)
                    {
                        case 0: newCondition = "Sick"; break;
                        case 1: newCondition = "HighBPM"; break;
                        case 2: newCondition = "Healthy"; break;
                        default: newCondition = "Sick"; break;
                    }
                    break;
                }
            case PatientIncidents.FellOver:
                {
                    int randomCounter = Random.Range(0, 3);
                    switch (randomCounter)
                    {
                        case 0: newCondition = "Bleeding"; break;
                        case 1: newCondition = "BrokenBone"; break;
                        case 2: newCondition = "Healthy"; break;
                        default: newCondition = "Bleeding"; break;
                    }
                    break;
                }
            case PatientIncidents.WorkAccident:
                {
                    int randomCounter = Random.Range(0, 3);
                    switch (randomCounter)
                    {
                        case 0: newCondition = "Bleeding"; break;
                        case 1: newCondition = "BrokenBone"; break;
                        case 2: newCondition = "Healthy"; break;
                        default: newCondition = "Bleeding"; break;
                    }
                    break;
                }
        }
        return newCondition;
    }

    private int RandomiseIncidentState(PatientIncidents Incident)
    {
        int newState = 100;
        switch (Incident)
        {
            case PatientIncidents.CarCrash:
                {
                    newState = Random.Range(20, 100);
                    break;
                }
            case PatientIncidents.MountainAccident:
                {
                    newState = Random.Range(40, 100);
                    break;
                }
            case PatientIncidents.Attacked:
                {
                    newState = Random.Range(40, 100);
                    break;
                }
            case PatientIncidents.Fight:
                {
                    newState = Random.Range(70, 100);
                    break;
                }
            case PatientIncidents.Exposed:
                {
                    newState = Random.Range(50, 100);
                    break;
                }
            case PatientIncidents.FellOver:
                {
                    newState = Random.Range(80, 100);
                    break;
                }
            case PatientIncidents.WorkAccident:
                {
                    newState = Random.Range(50, 100);
                    break;
                }
        }
        return newState;
    }
}
