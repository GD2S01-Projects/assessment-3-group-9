using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cChildPatientFactory : cPatientFactory
{
    public override IPatient CreatePatient()
    {
        Debug.Log("A new Child Patient has entered the Hospital");
        IPatient patient = new cChildPatient();
        SetPatientVariables(patient);
        return patient;
    }
}
