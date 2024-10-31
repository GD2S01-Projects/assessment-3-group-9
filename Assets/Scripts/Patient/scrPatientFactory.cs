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
                    _patient.GetComponent<scrPatient>().patientHeadCondition = RandomiseIncidentCondition(0, 0);
                    _patient.GetComponent<scrPatient>().patientHeadState = RandomiseIncidentState(0, 0);

                    //# Body
                    _patient.GetComponent<scrPatient>().patientBodyCondition = RandomiseIncidentCondition(1, 0);
                    _patient.GetComponent<scrPatient>().patientBodyState = RandomiseIncidentState(1, 0);

                    //# Left Arm
                    _patient.GetComponent<scrPatient>().patientLeftArmCondition = RandomiseIncidentCondition(2, 0);
                    _patient.GetComponent<scrPatient>().patientLeftArmState = RandomiseIncidentState(2, 0);

                    //# Right Arm
                    _patient.GetComponent<scrPatient>().patientRightArmCondition = RandomiseIncidentCondition(3, 0);
                    _patient.GetComponent<scrPatient>().patientRightArmState = RandomiseIncidentState(3, 0);

                    //# Left Leg
                    _patient.GetComponent<scrPatient>().patientLeftLegCondition = RandomiseIncidentCondition(4, 0);
                    _patient.GetComponent<scrPatient>().patientLeftLegState = RandomiseIncidentState(4, 0);

                    //# Right Leg
                    _patient.GetComponent<scrPatient>().patientRightLegCondition = RandomiseIncidentCondition(5, 0);
                    _patient.GetComponent<scrPatient>().patientRightLegState = RandomiseIncidentState(5, 0);
                    break;
                }
            case PatientIncidents.MountainAccident:
                {
                    //# Head
                    _patient.GetComponent<scrPatient>().patientHeadCondition = RandomiseIncidentCondition(0, 1);
                    _patient.GetComponent<scrPatient>().patientHeadState = RandomiseIncidentState(0, 1);

                    //# Body
                    _patient.GetComponent<scrPatient>().patientBodyCondition = RandomiseIncidentCondition(1, 1);
                    _patient.GetComponent<scrPatient>().patientBodyState = RandomiseIncidentState(1, 1);

                    //# Left Arm
                    _patient.GetComponent<scrPatient>().patientLeftArmCondition = RandomiseIncidentCondition(2, 1);
                    _patient.GetComponent<scrPatient>().patientLeftArmState = RandomiseIncidentState(2, 1);

                    //# Right Arm
                    _patient.GetComponent<scrPatient>().patientRightArmCondition = RandomiseIncidentCondition(3, 1);
                    _patient.GetComponent<scrPatient>().patientRightArmState = RandomiseIncidentState(3, 1);

                    //# Left Leg
                    _patient.GetComponent<scrPatient>().patientLeftLegCondition = RandomiseIncidentCondition(4, 1);
                    _patient.GetComponent<scrPatient>().patientLeftLegState = RandomiseIncidentState(4, 1);

                    //# Right Leg
                    _patient.GetComponent<scrPatient>().patientRightLegCondition = RandomiseIncidentCondition(5, 1);
                    _patient.GetComponent<scrPatient>().patientRightLegState = RandomiseIncidentState(5, 1);
                    break;
                }
            case PatientIncidents.Attacked:
                {
                    //# Head
                    _patient.GetComponent<scrPatient>().patientHeadCondition = RandomiseIncidentCondition(0, 0);
                    _patient.GetComponent<scrPatient>().patientHeadState = RandomiseIncidentState(0, 0);

                    //# Body
                    _patient.GetComponent<scrPatient>().patientBodyCondition = RandomiseIncidentCondition(1, 0);
                    _patient.GetComponent<scrPatient>().patientBodyState = RandomiseIncidentState(1, 0);

                    //# Left Arm
                    _patient.GetComponent<scrPatient>().patientLeftArmCondition = RandomiseIncidentCondition(2, 0);
                    _patient.GetComponent<scrPatient>().patientLeftArmState = RandomiseIncidentState(2, 0);

                    //# Right Arm
                    _patient.GetComponent<scrPatient>().patientRightArmCondition = RandomiseIncidentCondition(3, 0);
                    _patient.GetComponent<scrPatient>().patientRightArmState = RandomiseIncidentState(3, 0);

                    //# Left Leg
                    _patient.GetComponent<scrPatient>().patientLeftLegCondition = RandomiseIncidentCondition(4, 0);
                    _patient.GetComponent<scrPatient>().patientLeftLegState = RandomiseIncidentState(4, 0);

                    //# Right Leg
                    _patient.GetComponent<scrPatient>().patientRightLegCondition = RandomiseIncidentCondition(5, 0);
                    _patient.GetComponent<scrPatient>().patientRightLegState = RandomiseIncidentState(5, 0);
                    break;
                }
            case PatientIncidents.Fight:
                {
                    //# Head
                    _patient.GetComponent<scrPatient>().patientHeadCondition = RandomiseIncidentCondition(0, 0);
                    _patient.GetComponent<scrPatient>().patientHeadState = RandomiseIncidentState(0, 0);

                    //# Body
                    _patient.GetComponent<scrPatient>().patientBodyCondition = RandomiseIncidentCondition(1, 0);
                    _patient.GetComponent<scrPatient>().patientBodyState = RandomiseIncidentState(1, 0);

                    //# Left Arm
                    _patient.GetComponent<scrPatient>().patientLeftArmCondition = RandomiseIncidentCondition(2, 0);
                    _patient.GetComponent<scrPatient>().patientLeftArmState = RandomiseIncidentState(2, 0);

                    //# Right Arm
                    _patient.GetComponent<scrPatient>().patientRightArmCondition = RandomiseIncidentCondition(3, 0);
                    _patient.GetComponent<scrPatient>().patientRightArmState = RandomiseIncidentState(3, 0);

                    //# Left Leg
                    _patient.GetComponent<scrPatient>().patientLeftLegCondition = RandomiseIncidentCondition(4, 0);
                    _patient.GetComponent<scrPatient>().patientLeftLegState = RandomiseIncidentState(4, 0);

                    //# Right Leg
                    _patient.GetComponent<scrPatient>().patientRightLegCondition = RandomiseIncidentCondition(5, 0);
                    _patient.GetComponent<scrPatient>().patientRightLegState = RandomiseIncidentState(5, 0);
                    break;
                }
            case PatientIncidents.Exposed:
                {
                    //# Head
                    _patient.GetComponent<scrPatient>().patientHeadCondition = RandomiseIncidentCondition(0, 0);
                    _patient.GetComponent<scrPatient>().patientHeadState = RandomiseIncidentState(0, 0);

                    //# Body
                    _patient.GetComponent<scrPatient>().patientBodyCondition = RandomiseIncidentCondition(1, 0);
                    _patient.GetComponent<scrPatient>().patientBodyState = RandomiseIncidentState(1, 0);

                    //# Left Arm
                    _patient.GetComponent<scrPatient>().patientLeftArmCondition = RandomiseIncidentCondition(2, 0);
                    _patient.GetComponent<scrPatient>().patientLeftArmState = RandomiseIncidentState(2, 0);

                    //# Right Arm
                    _patient.GetComponent<scrPatient>().patientRightArmCondition = RandomiseIncidentCondition(3, 0);
                    _patient.GetComponent<scrPatient>().patientRightArmState = RandomiseIncidentState(3, 0);

                    //# Left Leg
                    _patient.GetComponent<scrPatient>().patientLeftLegCondition = RandomiseIncidentCondition(4, 0);
                    _patient.GetComponent<scrPatient>().patientLeftLegState = RandomiseIncidentState(4, 0);

                    //# Right Leg
                    _patient.GetComponent<scrPatient>().patientRightLegCondition = RandomiseIncidentCondition(5, 0);
                    _patient.GetComponent<scrPatient>().patientRightLegState = RandomiseIncidentState(5, 0);
                    break;
                }
            case PatientIncidents.FellOver:
                {
                    //# Head
                    _patient.GetComponent<scrPatient>().patientHeadCondition = RandomiseIncidentCondition(0, 0);
                    _patient.GetComponent<scrPatient>().patientHeadState = RandomiseIncidentState(0, 0);

                    //# Body
                    _patient.GetComponent<scrPatient>().patientBodyCondition = RandomiseIncidentCondition(1, 0);
                    _patient.GetComponent<scrPatient>().patientBodyState = RandomiseIncidentState(1, 0);

                    //# Left Arm
                    _patient.GetComponent<scrPatient>().patientLeftArmCondition = RandomiseIncidentCondition(2, 0);
                    _patient.GetComponent<scrPatient>().patientLeftArmState = RandomiseIncidentState(2, 0);

                    //# Right Arm
                    _patient.GetComponent<scrPatient>().patientRightArmCondition = RandomiseIncidentCondition(3, 0);
                    _patient.GetComponent<scrPatient>().patientRightArmState = RandomiseIncidentState(3, 0);

                    //# Left Leg
                    _patient.GetComponent<scrPatient>().patientLeftLegCondition = RandomiseIncidentCondition(4, 0);
                    _patient.GetComponent<scrPatient>().patientLeftLegState = RandomiseIncidentState(4, 0);

                    //# Right Leg
                    _patient.GetComponent<scrPatient>().patientRightLegCondition = RandomiseIncidentCondition(5, 0);
                    _patient.GetComponent<scrPatient>().patientRightLegState = RandomiseIncidentState(5, 0);
                    break;
                }
            case PatientIncidents.WorkAccident:
                {
                    //# Head
                    _patient.GetComponent<scrPatient>().patientHeadCondition = RandomiseIncidentCondition(0, 0);
                    _patient.GetComponent<scrPatient>().patientHeadState = RandomiseIncidentState(0, 0);

                    //# Body
                    _patient.GetComponent<scrPatient>().patientBodyCondition = RandomiseIncidentCondition(1, 0);
                    _patient.GetComponent<scrPatient>().patientBodyState = RandomiseIncidentState(1, 0);

                    //# Left Arm
                    _patient.GetComponent<scrPatient>().patientLeftArmCondition = RandomiseIncidentCondition(2, 0);
                    _patient.GetComponent<scrPatient>().patientLeftArmState = RandomiseIncidentState(2, 0);

                    //# Right Arm
                    _patient.GetComponent<scrPatient>().patientRightArmCondition = RandomiseIncidentCondition(3, 0);
                    _patient.GetComponent<scrPatient>().patientRightArmState = RandomiseIncidentState(3, 0);

                    //# Left Leg
                    _patient.GetComponent<scrPatient>().patientLeftLegCondition = RandomiseIncidentCondition(4, 0);
                    _patient.GetComponent<scrPatient>().patientLeftLegState = RandomiseIncidentState(4, 0);

                    //# Right Leg
                    _patient.GetComponent<scrPatient>().patientRightLegCondition = RandomiseIncidentCondition(5, 0);
                    _patient.GetComponent<scrPatient>().patientRightLegState = RandomiseIncidentState(5, 0);
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
                                int randomCounter = Random.Range(0, 2);
                                switch (randomCounter)
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
        return newState;
    }
}
