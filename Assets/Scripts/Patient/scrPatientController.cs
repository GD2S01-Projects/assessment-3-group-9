using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrPatientController : MonoBehaviour
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
        scrPatientFactory.instance.CreatePatient(emptyVector3);
        iTotalCreatedToday++;
    }
}
