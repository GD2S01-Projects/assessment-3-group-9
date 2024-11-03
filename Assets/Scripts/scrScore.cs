using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrScore : MonoBehaviour
{
    // Score Variables for player
    int iTotalScore = 0;
    int iBaseScoreValue = 100;
    float fScoreMultiplier = 1.0f;

    // Score variables for game
    // I would like to replace this list for some kind of dynamic memorey structure
    //VVVVVVVVVVVVVVVVVVV
    //int iNurseScore1 = 0;
    //int iNurseScore2 = 0;
    //int iNurseScore3 = 0;
    //int iNurseScore4 = 0;
    //int iNurseScore5 = 0;
    //int iNurseScore6 = 0;
    //int iNurseScore7 = 0;
    //^^^^^^^^^^^^^^^^^^

    // Update is called once per frame
    private void Update()
    {
        print("Player Score : " + iTotalScore);
        /*print("AI Nurse1 Score : " + iNurseScore1);
        print("AI Nurse2 Score : " + iNurseScore2);
        print("AI Nurse3 Score : " + iNurseScore3);
        print("AI Nurse4 Score : " + iNurseScore4);
        print("AI Nurse5 Score : " + iNurseScore5);
        print("AI Nurse6 Score : " + iNurseScore6);
        print("AI Nurse7 Score : " + iNurseScore7);*/
    }

    public void UpdatePlayerScore()
    {
        iTotalScore += (int)(iBaseScoreValue * fScoreMultiplier);
        print(iTotalScore);
        Update();
    }

    public void UppdateAllAIScore()
    {
        /*iNurseScore1++;
        iNurseScore2++;
        iNurseScore3++;
        iNurseScore4++;
        iNurseScore5++;
        iNurseScore6++;
        iNurseScore7++;*/
        Update();
    }
}