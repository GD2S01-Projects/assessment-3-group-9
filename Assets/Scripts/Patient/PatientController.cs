using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatientController : MonoBehaviour
{
    private string sName = "Gary";
    private float fOverallHealth;


    // Start is called before the first frame update
    void Start()
    {
        fOverallHealth = Random.Range(0.0f, 100.0f);
        DisplayInformation();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Create(string _Name, float _OverallHealth)
    {
        sName = _Name;
        fOverallHealth = _OverallHealth;
    }

    void DisplayInformation()
    {
        Debug.Log(sName);
        Debug.Log(fOverallHealth);
    }
}
