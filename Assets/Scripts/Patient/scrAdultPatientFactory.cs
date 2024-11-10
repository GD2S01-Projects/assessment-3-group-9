using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cAdultPatientFactory : cPatientFactory
{
    public override IPatient CreatePatient()
    {
        Debug.Log("A new Adult Patient has entered the Hospital");
        IPatient patient = new cAdultPatient();
        SetPatientVariables(patient);
        return patient;
    }
}
