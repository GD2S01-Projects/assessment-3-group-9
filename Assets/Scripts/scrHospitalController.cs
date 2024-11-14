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

   

    public void AdmitPatient()
    {
        cAdultPatientFactory adultPatientFactory = new cAdultPatientFactory();
        cChildPatientFactory childPatientFactory = new cChildPatientFactory();

        int iCoinFlip = Random.Range(0, 2);

        // Create Child Patient
        if (iCoinFlip == 0)
        {
             IPatient newChildPatient = childPatientFactory.CreatePatient();
        }
        // Create Adult Patient
        else if (iCoinFlip == 1)
        {
            IPatient newAdultPatient = adultPatientFactory.CreatePatient();
        }
    }
}
