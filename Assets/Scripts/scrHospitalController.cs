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

    public static int iPatientMaxCapacity = 13;
    public int iPatientArraySize = 0;
    public IPatient[] PatientArray = new IPatient[iPatientMaxCapacity];

    //prviate Patient
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        iPatientArraySize = 0;
        for (int i = 0; i < iPatientMaxCapacity; i++)
        {
            if (PatientArray[i] != null) 
            {
                iPatientArraySize++;
            }
        }
    }

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
