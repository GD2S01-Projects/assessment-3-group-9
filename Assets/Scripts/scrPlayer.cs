using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPatient
{ 
    public string sName {  get; set; }
    public float fTotalHealth { get; set; }
}

public class scr_Patient : MonoBehaviour, IPatient 
{
    public string sName { get; set; }
    public float fTotalHealth { get; set; } = 10.5f;
}