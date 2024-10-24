using UnityEngine;

public class Diagnosis
{
    // Method to confirm diagnosis and provide feedback
    public static bool ConfirmDiagnosis(string actualCondition, string nurseDiagnosis)
    {
        if (actualCondition == nurseDiagnosis)
        {
            Debug.Log("Correct diagnosis! The nurse has identified the condition as " + actualCondition);
            return true;
        }
        else
        {
            Debug.Log("Incorrect diagnosis. The patient had " + actualCondition + " but was diagnosed with " + nurseDiagnosis);
            return false;
        }
    }
}
