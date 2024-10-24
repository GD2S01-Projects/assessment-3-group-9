using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatientController : scrBaseCharacter
{
    public Camera mainCamera;
    public float fEnterInterval;
    private float fCurrentTimer = 0.0f;
    private int iTotalCreatedToday = 0;

    void Update()
    {
        fCurrentTimer += Time.deltaTime;
        if (fCurrentTimer >= fEnterInterval)
        {
            CreatePatients();
            fCurrentTimer = 0.0f;
        }
    }

    void CreatePatients()
    {
        Vector3 emptyVector3 = new Vector3(0, 0, 0);
        PatientName randomType = (PatientName)Random.Range(0, System.Enum.GetValues(typeof(PatientName)).Length);
        Debug.Log(randomType);
        PatientFactory.instance.CreatePatient(randomType, emptyVector3);
        iTotalCreatedToday++;
    }
}
