using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PatientName
{
    Freddy,
    Foxy,
    Chica,
    Bonnie
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

    public GameObject CreatePatient(PatientName _type, Vector3 _position)
    {
        GameObject patient = Instantiate(patientPrefab, _position, Quaternion.identity);
        AttachPatientScript(_type, patient);
        Debug.Log("A new Patient has entered the Hospital");
        Debug.Log(patient.GetType());
        return patient;
    }

    private void AttachPatientScript(PatientName _type, GameObject _patient)
    {
        switch (_type)
        {
            case PatientName.Freddy:
                {
                    //_patient.AddComponent<scrPatient>();
                    break;
                }
            case PatientName.Foxy:
                {
                    //_patient.AddComponent<scrPatient>();
                    break;
                }
            case PatientName.Chica:
                {
                    //_patient.AddComponent<scrPatient>();
                    break;
                }
            case PatientName.Bonnie:
                {
                    //_patient.AddComponent<scrPatient>();
                    break;
                }
        }
    }
}
