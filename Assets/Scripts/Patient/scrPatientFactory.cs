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

public class scrPatientFactory : MonoBehaviour
{
    public static scrPatientFactory instance { get; private set; }
    public GameObject patientPrefab;

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    public GameObject CreatePatient(Vector3 _position)
    {
        GameObject patient = Instantiate(patientPrefab, _position, Quaternion.identity);
        patient.AddComponent<scrPatient>();
        SetPatientVariables(patient);
        Debug.Log("A new Patient has entered the Hospital");
        return patient;
    }

    private void SetPatientVariables(GameObject _patient)
    {
        PatientIncidents randomIncident = (PatientIncidents)Random.Range(0, System.Enum.GetValues(typeof(PatientIncidents)).Length);
        switch(randomIncident)
        {
            case PatientIncidents.CarCrash:
                {
                    //# Head
                    _patient.GetComponent<scrPatient>().patientHeadCondition = RandomiseIncidentCondition(0, PatientIncidents.CarCrash);
                    _patient.GetComponent<scrPatient>().patientHeadState = RandomiseIncidentState(0, PatientIncidents.CarCrash);

                    //# Body
                    _patient.GetComponent<scrPatient>().patientBodyCondition = RandomiseIncidentCondition(1, PatientIncidents.CarCrash);
                    _patient.GetComponent<scrPatient>().patientBodyState = RandomiseIncidentState(1, PatientIncidents.CarCrash);

                    //# Left Arm
                    _patient.GetComponent<scrPatient>().patientLeftArmCondition = RandomiseIncidentCondition(2, PatientIncidents.CarCrash);
                    _patient.GetComponent<scrPatient>().patientLeftArmState = RandomiseIncidentState(2, PatientIncidents.CarCrash);

                    //# Right Arm
                    _patient.GetComponent<scrPatient>().patientRightArmCondition = RandomiseIncidentCondition(3, PatientIncidents.CarCrash);
                    _patient.GetComponent<scrPatient>().patientRightArmState = RandomiseIncidentState(3, PatientIncidents.CarCrash);

                    //# Left Leg
                    _patient.GetComponent<scrPatient>().patientLeftLegCondition = RandomiseIncidentCondition(4, PatientIncidents.CarCrash);
                    _patient.GetComponent<scrPatient>().patientLeftLegState = RandomiseIncidentState(4, PatientIncidents.CarCrash);

                    //# Right Leg
                    _patient.GetComponent<scrPatient>().patientRightLegCondition = RandomiseIncidentCondition(5, PatientIncidents.CarCrash);
                    _patient.GetComponent<scrPatient>().patientRightLegState = RandomiseIncidentState(5, PatientIncidents.CarCrash);
                    break;
                }
            case PatientIncidents.MountainAccident:
                {
                    //# Head
                    _patient.GetComponent<scrPatient>().patientHeadCondition = RandomiseIncidentCondition(0, PatientIncidents.MountainAccident);
                    _patient.GetComponent<scrPatient>().patientHeadState = RandomiseIncidentState(0, PatientIncidents.MountainAccident);

                    //# Body
                    _patient.GetComponent<scrPatient>().patientBodyCondition = RandomiseIncidentCondition(1, PatientIncidents.MountainAccident);
                    _patient.GetComponent<scrPatient>().patientBodyState = RandomiseIncidentState(1, PatientIncidents.MountainAccident);

                    //# Left Arm
                    _patient.GetComponent<scrPatient>().patientLeftArmCondition = RandomiseIncidentCondition(2, PatientIncidents.MountainAccident);
                    _patient.GetComponent<scrPatient>().patientLeftArmState = RandomiseIncidentState(2, PatientIncidents.MountainAccident);

                    //# Right Arm
                    _patient.GetComponent<scrPatient>().patientRightArmCondition = RandomiseIncidentCondition(3, PatientIncidents.MountainAccident);
                    _patient.GetComponent<scrPatient>().patientRightArmState = RandomiseIncidentState(3, PatientIncidents.MountainAccident);

                    //# Left Leg
                    _patient.GetComponent<scrPatient>().patientLeftLegCondition = RandomiseIncidentCondition(4, PatientIncidents.MountainAccident);
                    _patient.GetComponent<scrPatient>().patientLeftLegState = RandomiseIncidentState(4, PatientIncidents.MountainAccident);

                    //# Right Leg
                    _patient.GetComponent<scrPatient>().patientRightLegCondition = RandomiseIncidentCondition(5, PatientIncidents.MountainAccident);
                    _patient.GetComponent<scrPatient>().patientRightLegState = RandomiseIncidentState(5, PatientIncidents.MountainAccident);
                    break;
                }
            case PatientIncidents.Attacked:
                {
                    //# Head
                    _patient.GetComponent<scrPatient>().patientHeadCondition = RandomiseIncidentCondition(0, PatientIncidents.Attacked);
                    _patient.GetComponent<scrPatient>().patientHeadState = RandomiseIncidentState(0, PatientIncidents.Attacked);

                    //# Body
                    _patient.GetComponent<scrPatient>().patientBodyCondition = RandomiseIncidentCondition(1, PatientIncidents.Attacked);
                    _patient.GetComponent<scrPatient>().patientBodyState = RandomiseIncidentState(1, PatientIncidents.Attacked);

                    //# Left Arm
                    _patient.GetComponent<scrPatient>().patientLeftArmCondition = RandomiseIncidentCondition(2, PatientIncidents.Attacked);
                    _patient.GetComponent<scrPatient>().patientLeftArmState = RandomiseIncidentState(2, PatientIncidents.Attacked);

                    //# Right Arm
                    _patient.GetComponent<scrPatient>().patientRightArmCondition = RandomiseIncidentCondition(3, PatientIncidents.Attacked);
                    _patient.GetComponent<scrPatient>().patientRightArmState = RandomiseIncidentState(3, PatientIncidents.Attacked);

                    //# Left Leg
                    _patient.GetComponent<scrPatient>().patientLeftLegCondition = RandomiseIncidentCondition(4, PatientIncidents.Attacked);
                    _patient.GetComponent<scrPatient>().patientLeftLegState = RandomiseIncidentState(4, PatientIncidents.Attacked);

                    //# Right Leg
                    _patient.GetComponent<scrPatient>().patientRightLegCondition = RandomiseIncidentCondition(5, PatientIncidents.Attacked);
                    _patient.GetComponent<scrPatient>().patientRightLegState = RandomiseIncidentState(5, PatientIncidents.Attacked);
                    break;
                }
            case PatientIncidents.Fight:
                {
                    //# Head
                    _patient.GetComponent<scrPatient>().patientHeadCondition = RandomiseIncidentCondition(0, PatientIncidents.Fight);
                    _patient.GetComponent<scrPatient>().patientHeadState = RandomiseIncidentState(0, PatientIncidents.Fight);

                    //# Body
                    _patient.GetComponent<scrPatient>().patientBodyCondition = RandomiseIncidentCondition(1, PatientIncidents.Fight);
                    _patient.GetComponent<scrPatient>().patientBodyState = RandomiseIncidentState(1, PatientIncidents.Fight);

                    //# Left Arm
                    _patient.GetComponent<scrPatient>().patientLeftArmCondition = RandomiseIncidentCondition(2, PatientIncidents.Fight);
                    _patient.GetComponent<scrPatient>().patientLeftArmState = RandomiseIncidentState(2, PatientIncidents.Fight);

                    //# Right Arm
                    _patient.GetComponent<scrPatient>().patientRightArmCondition = RandomiseIncidentCondition(3, PatientIncidents.Fight);
                    _patient.GetComponent<scrPatient>().patientRightArmState = RandomiseIncidentState(3, PatientIncidents.Fight);

                    //# Left Leg
                    _patient.GetComponent<scrPatient>().patientLeftLegCondition = RandomiseIncidentCondition(4, PatientIncidents.Fight);
                    _patient.GetComponent<scrPatient>().patientLeftLegState = RandomiseIncidentState(4, PatientIncidents.Fight);

                    //# Right Leg
                    _patient.GetComponent<scrPatient>().patientRightLegCondition = RandomiseIncidentCondition(5, PatientIncidents.Fight);
                    _patient.GetComponent<scrPatient>().patientRightLegState = RandomiseIncidentState(5, PatientIncidents.Fight);
                    break;
                }
            case PatientIncidents.Exposed:
                {
                    //# Head
                    _patient.GetComponent<scrPatient>().patientHeadCondition = RandomiseIncidentCondition(0, PatientIncidents.Exposed);
                    _patient.GetComponent<scrPatient>().patientHeadState = RandomiseIncidentState(0, PatientIncidents.Exposed);

                    //# Body
                    _patient.GetComponent<scrPatient>().patientBodyCondition = RandomiseIncidentCondition(1, PatientIncidents.Exposed);
                    _patient.GetComponent<scrPatient>().patientBodyState = RandomiseIncidentState(1, PatientIncidents.Exposed);

                    //# Left Arm
                    _patient.GetComponent<scrPatient>().patientLeftArmCondition = RandomiseIncidentCondition(2, PatientIncidents.Exposed);
                    _patient.GetComponent<scrPatient>().patientLeftArmState = RandomiseIncidentState(2, PatientIncidents.Exposed);

                    //# Right Arm
                    _patient.GetComponent<scrPatient>().patientRightArmCondition = RandomiseIncidentCondition(3, PatientIncidents.Exposed);
                    _patient.GetComponent<scrPatient>().patientRightArmState = RandomiseIncidentState(3, PatientIncidents.Exposed);

                    //# Left Leg
                    _patient.GetComponent<scrPatient>().patientLeftLegCondition = RandomiseIncidentCondition(4, PatientIncidents.Exposed);
                    _patient.GetComponent<scrPatient>().patientLeftLegState = RandomiseIncidentState(4, PatientIncidents.Exposed);

                    //# Right Leg
                    _patient.GetComponent<scrPatient>().patientRightLegCondition = RandomiseIncidentCondition(5, PatientIncidents.Exposed);
                    _patient.GetComponent<scrPatient>().patientRightLegState = RandomiseIncidentState(5, PatientIncidents.Exposed);
                    break;
                }
            case PatientIncidents.FellOver:
                {
                    //# Head
                    _patient.GetComponent<scrPatient>().patientHeadCondition = RandomiseIncidentCondition(0, PatientIncidents.FellOver);
                    _patient.GetComponent<scrPatient>().patientHeadState = RandomiseIncidentState(0, PatientIncidents.FellOver);

                    //# Body
                    _patient.GetComponent<scrPatient>().patientBodyCondition = RandomiseIncidentCondition(1, PatientIncidents.FellOver);
                    _patient.GetComponent<scrPatient>().patientBodyState = RandomiseIncidentState(1, PatientIncidents.FellOver);

                    //# Left Arm
                    _patient.GetComponent<scrPatient>().patientLeftArmCondition = RandomiseIncidentCondition(2, PatientIncidents.FellOver);
                    _patient.GetComponent<scrPatient>().patientLeftArmState = RandomiseIncidentState(2, PatientIncidents.FellOver);

                    //# Right Arm
                    _patient.GetComponent<scrPatient>().patientRightArmCondition = RandomiseIncidentCondition(3, PatientIncidents.FellOver);
                    _patient.GetComponent<scrPatient>().patientRightArmState = RandomiseIncidentState(3, PatientIncidents.FellOver);

                    //# Left Leg
                    _patient.GetComponent<scrPatient>().patientLeftLegCondition = RandomiseIncidentCondition(4, PatientIncidents.FellOver);
                    _patient.GetComponent<scrPatient>().patientLeftLegState = RandomiseIncidentState(4, PatientIncidents.FellOver);

                    //# Right Leg
                    _patient.GetComponent<scrPatient>().patientRightLegCondition = RandomiseIncidentCondition(5, PatientIncidents.FellOver);
                    _patient.GetComponent<scrPatient>().patientRightLegState = RandomiseIncidentState(5, PatientIncidents.FellOver);
                    break;
                }
            case PatientIncidents.WorkAccident:
                {
                    //# Head
                    _patient.GetComponent<scrPatient>().patientHeadCondition = RandomiseIncidentCondition(0, PatientIncidents.WorkAccident);
                    _patient.GetComponent<scrPatient>().patientHeadState = RandomiseIncidentState(0, PatientIncidents.WorkAccident);

                    //# Body
                    _patient.GetComponent<scrPatient>().patientBodyCondition = RandomiseIncidentCondition(1, PatientIncidents.WorkAccident);
                    _patient.GetComponent<scrPatient>().patientBodyState = RandomiseIncidentState(1, PatientIncidents.WorkAccident);

                    //# Left Arm
                    _patient.GetComponent<scrPatient>().patientLeftArmCondition = RandomiseIncidentCondition(2, PatientIncidents.WorkAccident);
                    _patient.GetComponent<scrPatient>().patientLeftArmState = RandomiseIncidentState(2, PatientIncidents.WorkAccident);

                    //# Right Arm
                    _patient.GetComponent<scrPatient>().patientRightArmCondition = RandomiseIncidentCondition(3, PatientIncidents.WorkAccident);
                    _patient.GetComponent<scrPatient>().patientRightArmState = RandomiseIncidentState(3, PatientIncidents.WorkAccident);

                    //# Left Leg
                    _patient.GetComponent<scrPatient>().patientLeftLegCondition = RandomiseIncidentCondition(4, PatientIncidents.WorkAccident);
                    _patient.GetComponent<scrPatient>().patientLeftLegState = RandomiseIncidentState(4, PatientIncidents.WorkAccident);

                    //# Right Leg
                    _patient.GetComponent<scrPatient>().patientRightLegCondition = RandomiseIncidentCondition(5, PatientIncidents.WorkAccident);
                    _patient.GetComponent<scrPatient>().patientRightLegState = RandomiseIncidentState(5, PatientIncidents.WorkAccident);
                    break;
                }
        }
    }

    private string RandomiseIncidentCondition(int _PartID, PatientIncidents Incident)
    {
        string newCondition = "Healthy";
        switch (Incident)
        {
            case PatientIncidents.CarCrash:
                {
                    switch (_PartID)
                    {
                        //# Head
                        case 0:
                            {
                                int randomCounter = Random.Range(0, 2);
                                switch(randomCounter)
                                {
                                    case 0: newCondition = "Bleeding"; break;
                                    case 1: newCondition = "Bruised"; break;
                                    default: newCondition = "Bleeding"; break;
                                }
                                break;
                            }
                        //# Body
                        case 1:
                            {
                                newCondition = "Bruised";
                                break;
                            }
                        //# Left Arm
                        case 2:
                            {
                                int randomCounter = Random.Range(0, 3);
                                switch (randomCounter)
                                {
                                    case 0: newCondition = "Bleeding"; break;
                                    case 1: newCondition = "Bruised"; break;
                                    case 2: newCondition = "Broken Bone"; break;
                                    default: newCondition = "Bleeding"; break;
                                }
                                break;
                            }
                        //# Right Arm
                        case 3:
                            {
                                newCondition = "Healthy"; 
                                break;
                            }
                        //# Left Leg
                        case 4:
                            {
                                int randomCounter = Random.Range(0, 2);
                                switch (randomCounter)
                                {
                                    case 0: newCondition = "Bleeding"; break;
                                    case 1: newCondition = "Bruised"; break;
                                    default: newCondition = "Bleeding"; break;
                                }
                                break;
                            }
                        //# Right Leg
                        case 5:
                            {
                                int randomCounter = Random.Range(0, 2);
                                switch (randomCounter)
                                {
                                    case 0: newCondition = "Bleeding"; break;
                                    case 1: newCondition = "Broken Bone"; break;
                                    default: newCondition = "Bleeding"; break;
                                }
                                break;
                            }
                    }
                    break;
                }
            case PatientIncidents.MountainAccident:
                {
                    switch (_PartID)
                    {
                        //# Head
                        case 0:
                            {
                                int randomCounter = Random.Range(0, 2);
                                switch (randomCounter)
                                {
                                    case 0: newCondition = "Frostbite"; break;
                                    case 1: newCondition = "Bruised"; break;
                                    default: newCondition = "Frostbite"; break;
                                }
                                break;
                            }
                        //# Body
                        case 1:
                            {
                                int randomCounter = Random.Range(0, 2);
                                switch (randomCounter)
                                {
                                    case 0: newCondition = "Frostbite"; break;
                                    case 1: newCondition = "Bruised"; break;
                                    default: newCondition = "Frostbite"; break;
                                }
                                break;
                            }
                        //# Left Arm
                        case 2:
                            {
                                int randomCounter = Random.Range(0, 3);
                                switch (randomCounter)
                                {
                                    case 0: newCondition = "Bleeding"; break;
                                    case 1: newCondition = "Frostbite"; break;
                                    case 2: newCondition = "Healthy"; break;
                                    default: newCondition = "Frostbite"; break;
                                }
                                break;
                            }
                        //# Right Arm
                        case 3:
                            {
                                newCondition = "Frostbite"; 
                                break;
                            }
                        //# Left Leg
                        case 4:
                            {
                                int randomCounter = Random.Range(0, 3);
                                switch (randomCounter)
                                {
                                    case 0: newCondition = "Frostbite"; break;
                                    case 1: newCondition = "Broken Bone"; break;
                                    case 2: newCondition = "Healthy"; break;
                                    default: newCondition = "Frostbite"; break;
                                }
                                break;
                            }
                        //# Right Leg
                        case 5:
                            {
                                int randomCounter = Random.Range(0, 2);
                                switch (randomCounter)
                                {
                                    case 0: newCondition = "Frostbite"; break;
                                    case 1: newCondition = "Broken Bone"; break;
                                    default: newCondition = "Frostbite"; break;
                                }
                                break;
                            }
                    }
                    break;
                }
            case PatientIncidents.Attacked:
                {
                    switch (_PartID)
                    {
                        //# Head
                        case 0:
                            {
                                newCondition = "Healthy"; 
                                break;
                            }
                        //# Body
                        case 1:
                            {
                                int randomCounter = Random.Range(0, 2);
                                switch (randomCounter)
                                {
                                    case 0: newCondition = "Bleeding"; break;
                                    case 1: newCondition = "Bruised"; break;
                                    default: newCondition = "Frostbite"; break;
                                }
                                break;
                            }
                        //# Left Arm
                        case 2:
                            {
                                int randomCounter = Random.Range(0, 3);
                                switch (randomCounter)
                                {
                                    case 0: newCondition = "Healthy"; break;
                                    case 1: newCondition = "Bruised"; break;
                                    case 2: newCondition = "Bleeding"; break;
                                    default: newCondition = "Healthy"; break;
                                }
                                break;
                            }
                        //# Right Arm
                        case 3:
                            {
                                int randomCounter = Random.Range(0, 3);
                                switch (randomCounter)
                                {
                                    case 0: newCondition = "Healthy"; break;
                                    case 1: newCondition = "Bruised"; break;
                                    case 2: newCondition = "Bleeding"; break;
                                    default: newCondition = "Healthy"; break;
                                }
                                break;
                            }
                        //# Left Leg
                        case 4:
                            {
                                int randomCounter = Random.Range(0, 3);
                                switch (randomCounter)
                                {
                                    case 0: newCondition = "Healthy"; break;
                                    case 1: newCondition = "Bruised"; break;
                                    case 2: newCondition = "Bleeding"; break;
                                    default: newCondition = "Healthy"; break;
                                }
                                break;
                            }
                        //# Right Leg
                        case 5:
                            {
                                int randomCounter = Random.Range(0, 3);
                                switch (randomCounter)
                                {
                                    case 0: newCondition = "Healthy"; break;
                                    case 1: newCondition = "Bruised"; break;
                                    case 2: newCondition = "Bleeding"; break;
                                    default: newCondition = "Healthy"; break;
                                }
                                break;
                            }
                    }
                    break;
                }
            case PatientIncidents.Fight:
                {
                    switch (_PartID)
                    {
                        //# Head
                        case 0:
                            {
                                newCondition = "Bruised"; 
                                break;
                            }
                        //# Body
                        case 1:
                            {
                                int randomCounter = Random.Range(0, 2);
                                switch (randomCounter)
                                {
                                    case 0: newCondition = "Healthy"; break;
                                    case 1: newCondition = "Bruised"; break;
                                    default: newCondition = "Healthy"; break;
                                }
                                break;
                            }
                        //# Left Arm
                        case 2:
                            {
                                int randomCounter = Random.Range(0, 2);
                                switch (randomCounter)
                                {
                                    case 0: newCondition = "Healthy"; break;
                                    case 1: newCondition = "Bruised"; break;
                                    default: newCondition = "Healthy"; break;
                                }
                                break;
                            }
                        //# Right Arm
                        case 3:
                            {
                                int randomCounter = Random.Range(0, 2);
                                switch (randomCounter)
                                {
                                    case 0: newCondition = "Healthy"; break;
                                    case 1: newCondition = "Bruised"; break;
                                    default: newCondition = "Healthy"; break;
                                }
                                break;
                            }
                        //# Left Leg
                        case 4:
                            {
                                newCondition = "Healthy"; break;
                            }
                        //# Right Leg
                        case 5:
                            {
                                newCondition = "Healthy"; break;
                            }
                    }
                    break;
                }
            case PatientIncidents.Exposed:
                {
                    switch (_PartID)
                    {
                        //# Head
                        case 0:
                            {
                                int randomCounter = Random.Range(0, 2);
                                switch (randomCounter)
                                {
                                    case 0: newCondition = "Frostbite"; break;
                                    case 1: newCondition = "Healthy"; break;
                                    default: newCondition = "Frostbite"; break;
                                }
                                break;
                            }
                        //# Body
                        case 1:
                            {
                                int randomCounter = Random.Range(0, 2);
                                switch (randomCounter)
                                {
                                    case 0: newCondition = "Frostbite"; break;
                                    case 1: newCondition = "Healthy"; break;
                                    default: newCondition = "Frostbite"; break;
                                }
                                break;
                            }
                        //# Left Arm
                        case 2:
                            {
                                int randomCounter = Random.Range(0, 2);
                                switch (randomCounter)
                                {
                                    case 0: newCondition = "Frostbite"; break;
                                    case 1: newCondition = "Healthy"; break;
                                    default: newCondition = "Frostbite"; break;
                                }
                                break;
                            }
                        //# Right Arm
                        case 3:
                            {
                                newCondition = "Frostbite"; 
                                break;
                            }
                        //# Left Leg
                        case 4:
                            {
                                int randomCounter = Random.Range(0, 2);
                                switch (randomCounter)
                                {
                                    case 0: newCondition = "Frostbite"; break;
                                    case 1: newCondition = "Healthy"; break;
                                    default: newCondition = "Frostbite"; break;
                                }
                                break;
                            }
                        //# Right Leg
                        case 5:
                            {
                                newCondition = "Frostbite"; 
                                break;
                            }
                    }
                    break;
                }
            case PatientIncidents.FellOver:
                {
                    switch (_PartID)
                    {
                        //# Head
                        case 0:
                            {
                                newCondition = "Healthy"; 
                                break;
                            }
                        //# Body
                        case 1:
                            {
                                newCondition = "Healthy"; 
                                break;
                            }
                        //# Left Arm
                        case 2:
                            {
                                newCondition = "Healthy"; 
                                break;
                            }
                        //# Right Arm
                        case 3:
                            {
                                newCondition = "Healthy"; 
                                break;
                            }
                        //# Left Leg
                        case 4:
                            {
                                int randomCounter = Random.Range(0, 2);
                                switch (randomCounter)
                                {
                                    case 0: newCondition = "Broken Bone"; break;
                                    case 1: newCondition = "Bruised"; break;
                                    default: newCondition = "Bruised"; break;
                                }
                                break;
                            }
                        //# Right Leg
                        case 5:
                            {
                                int randomCounter = Random.Range(0, 2);
                                switch (randomCounter)
                                {
                                    case 0: newCondition = "Broken Bone"; break;
                                    case 1: newCondition = "Bruised"; break;
                                    default: newCondition = "Bruised"; break;
                                }
                                break;
                            }
                    }
                    break;
                }
            case PatientIncidents.WorkAccident:
                {
                    switch (_PartID)
                    {
                        //# Head
                        case 0:
                            {
                                int randomCounter = Random.Range(0, 3);
                                switch (randomCounter)
                                {
                                    case 0: newCondition = "Bleeding"; break;
                                    case 1: newCondition = "Bruised"; break;
                                    case 2: newCondition = "Healthy"; break;
                                    default: newCondition = "Bleeding"; break;
                                }
                            }
                            break;
                        //# Body
                        case 1:
                            {
                                newCondition = "Bruised"; 
                                break;
                            }
                        //# Left Arm
                        case 2:
                            {
                                int randomCounter = Random.Range(0, 4);
                                switch (randomCounter)
                                {
                                    case 0: newCondition = "Bleeding"; break;
                                    case 1: newCondition = "Bruised"; break;
                                    case 2: newCondition = "Broken Bone"; break;
                                    case 3: newCondition = "Healthy"; break;
                                    default: newCondition = "Bleeding"; break;
                                }
                                break;
                            }
                        //# Right Arm
                        case 3:
                            {
                                newCondition = "Healthy"; 
                                break;
                            }
                        //# Left Leg
                        case 4:
                            {
                                int randomCounter = Random.Range(0, 2);
                                switch (randomCounter)
                                {
                                    case 0: newCondition = "Healthy"; break;
                                    case 1: newCondition = "Bruised"; break;
                                    default: newCondition = "Bleeding"; break;
                                }
                                break;
                            }
                        //# Right Leg
                        case 5:
                            {
                                int randomCounter = Random.Range(0, 2);
                                switch (randomCounter)
                                {
                                    case 0: newCondition = "Healthy"; break;
                                    case 1: newCondition = "Broken Bone"; break;
                                    default: newCondition = "Bleeding"; break;
                                }
                                break;
                            }
                    }
                    break;
                }
        }
        return newCondition;
    }

    private float RandomiseIncidentState(int _PartID, PatientIncidents Incident)
    {
        float newState = 100.0f;
        switch (Incident)
        {
            case PatientIncidents.CarCrash:
                {
                    switch (_PartID)
                    {
                        //# Head
                        case 0:
                            {
                                newState = Random.Range(0, 100);
                                break;
                            }
                        //# Body
                        case 1:
                            {
                                newState = Random.Range(50, 100);
                                break;
                            }
                        //# Left Arm
                        case 2:
                            {
                                newState = Random.Range(0, 100);
                                break;
                            }
                        //# Right Arm
                        case 3:
                            {
                                newState = 100f;
                                break;
                            }
                        //# Left Leg
                        case 4:
                            {
                                newState = Random.Range(0, 100);
                                break;
                            }
                        //# Right Leg
                        case 5:
                            {
                                newState = Random.Range(0, 100);
                                break;
                            }
                    }
                    break;
                }
            case PatientIncidents.MountainAccident:
                {
                    switch (_PartID)
                    {
                        //# Head
                        case 0:
                            {
                                newState = Random.Range(40, 100);
                                break;
                            }
                        //# Body
                        case 1:
                            {
                                newState = Random.Range(30, 100);
                                break;
                            }
                        //# Left Arm
                        case 2:
                            {
                                newState = Random.Range(0, 100);
                                break;
                            }
                        //# Right Arm
                        case 3:
                            {
                                newState = Random.Range(20, 80);
                                break;
                            }
                        //# Left Leg
                        case 4:
                            {
                                newState = Random.Range(30, 80);
                                break;
                            }
                        //# Right Leg
                        case 5:
                            {
                                newState = Random.Range(0, 50);
                                break;
                            }
                    }
                    break;
                }
            case PatientIncidents.Attacked:
                {
                    switch (_PartID)
                    {
                        //# Head
                        case 0:
                            {
                                newState = 100f;
                                break;
                            }
                        //# Body
                        case 1:
                            {
                                newState = Random.Range(40, 80);
                                break;
                            }
                        //# Left Arm
                        case 2:
                            {
                                newState = Random.Range(50, 100);
                                break;
                            }
                        //# Right Arm
                        case 3:
                            {
                                newState = Random.Range(50, 100);
                                break;
                            }
                        //# Left Leg
                        case 4:
                            {
                                newState = Random.Range(30, 100);
                                break;
                            }
                        //# Right Leg
                        case 5:
                            {
                                newState = Random.Range(30, 100);
                                break;
                            }
                    }
                    break;
                }
            case PatientIncidents.Fight:
                {
                    switch (_PartID)
                    {
                        //# Head
                        case 0:
                            {
                                newState = Random.Range(60, 100);
                                break;
                            }
                        //# Body
                        case 1:
                            {
                                newState = Random.Range(50, 100);
                                break;
                            }
                        //# Left Arm
                        case 2:
                            {
                                newState = Random.Range(50, 100);
                                break;
                            }
                        //# Right Arm
                        case 3:
                            {
                                newState = Random.Range(60, 100);
                                break;
                            }
                        //# Left Leg
                        case 4:
                            {
                                newState = 100f;
                                break;
                            }
                        //# Right Leg
                        case 5:
                            {
                                newState = 100f;
                                break;
                            }
                    }
                    break;
                }
            case PatientIncidents.Exposed:
                {
                    switch (_PartID)
                    {
                        //# Head
                        case 0:
                            {
                                newState = Random.Range(40, 100);
                                break;
                            }
                        //# Body
                        case 1:
                            {
                                newState = Random.Range(40, 100);
                                break;
                            }
                        //# Left Arm
                        case 2:
                            {
                                newState = Random.Range(10, 100);
                                break;
                            }
                        //# Right Arm
                        case 3:
                            {
                                newState = Random.Range(10, 100);
                                break;
                            }
                        //# Left Leg
                        case 4:
                            {
                                newState = Random.Range(40, 100);
                                break;
                            }
                        //# Right Leg
                        case 5:
                            {
                                newState = Random.Range(40, 100);
                                break;
                            }
                    }
                    break;
                }
            case PatientIncidents.FellOver:
                {
                    switch (_PartID)
                    {
                        //# Head
                        case 0:
                            {
                                newState = 100f;
                                break;
                            }
                        //# Body
                        case 1:
                            {
                                newState = 100f;
                                break;
                            }
                        //# Left Arm
                        case 2:
                            {
                                newState = 100f;
                                break;
                            }
                        //# Right Arm
                        case 3:
                            {
                                newState = 100f;
                                break;
                            }
                        //# Left Leg
                        case 4:
                            {
                                newState = Random.Range(40, 100);
                                break;
                            }
                        //# Right Leg
                        case 5:
                            {
                                newState = Random.Range(40, 100);
                                break;
                            }
                    }
                    break;
                }
            case PatientIncidents.WorkAccident:
                {
                    switch (_PartID)
                    {
                        //# Head
                        case 0:
                            {
                                newState = Random.Range(40, 80);
                            }
                            break;
                        //# Body
                        case 1:
                            {
                                newState = Random.Range(40, 60);
                                break;
                            }
                        //# Left Arm
                        case 2:
                            {
                                newState = Random.Range(20, 100);
                                break;
                            }
                        //# Right Arm
                        case 3:
                            {
                                newState = 100f;
                                break;
                            }
                        //# Left Leg
                        case 4:
                            {
                                newState = Random.Range(40, 80);
                                break;
                            }
                        //# Right Leg
                        case 5:
                            {
                                newState = Random.Range(40, 80);
                                break;
                            }
                    }
                    break;
                }
        }
        return newState;
    }
}
