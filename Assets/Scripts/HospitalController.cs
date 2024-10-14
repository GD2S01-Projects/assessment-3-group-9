using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class HospitalController : MonoBehaviour
{
    public RoomController Room1;
    public RoomController Room2;
    public RoomController Room3;
    public RoomController Room4;
    public RoomController Room5;

    public PatientController PatientMaster;

    public int iPatientCapacity = 50;

    //prviate Patient
    // Start is called before the first frame update
    void Start()
    {
        PatientMaster = GetComponent<PatientController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T)) 
        {
            AdmitPatient();
        }
    }

    void AdmitPatient()
    {
    }
}
