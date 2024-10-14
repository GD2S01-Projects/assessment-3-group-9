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
    int iNurseScore1 = 0;
    int iNurseScore2 = 0;
    int iNurseScore3 = 0;
    int iNurseScore4 = 0;
    int iNurseScore5 = 0;
    int iNurseScore6 = 0;
    int iNurseScore7 = 0;
    //^^^^^^^^^^^^^^^^^^

    // Update is called once per frame
    void Update()
    {

    }

    void UpdatePlayerScore()
    {
        iTotalScore += (int)(iBaseScoreValue * fScoreMultiplier);
        print(iTotalScore);
    }
}
