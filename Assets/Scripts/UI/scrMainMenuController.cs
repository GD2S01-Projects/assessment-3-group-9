/***********************************************************************
Bachelor of Software Engineering
Media Design School
Auckland
New Zealand
(c) [2024] Media Design School
File Name : scrMainMenuController.cs
Description : Controls the main menu functions, such as loading a new scene and quiting the application
Author : Seth Hazelwood-Bradley
Mail : seth.hazelwoodbradley@mds.ac.nz
**************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scrMainMenuController : MonoBehaviour
{
    public string msLoadGame;
    // Load the game scene
    public void PlayGameButton()
    {
        SceneManager.LoadScene(msLoadGame);
    }
    // ---

    // Quit Game
    public void ExitButton()
    {
        Application.Quit();
    }
    // ---
}
