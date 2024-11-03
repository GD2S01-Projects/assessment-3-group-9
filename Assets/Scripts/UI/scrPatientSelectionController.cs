using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scrPatientSelection : MonoBehaviour
{
    public string msLoadDiagnosisScreen;
    public DebugLog debugLog; // Reference to the DebugLog script
    public void Button1()
    {
        debugLog.AddMessage("Button 1 Pressed");
    }

    public void ConfirmPatientSelectionButton()
    {
        debugLog.AddMessage("Patient Selected");
        SceneManager.LoadScene(msLoadDiagnosisScreen);
    }
}
