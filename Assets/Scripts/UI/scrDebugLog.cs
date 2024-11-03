/***********************************************************************
Bachelor of Software Engineering
Media Design School
Auckland
New Zealand
(c) [2024] Media Design School
File Name : DebugLog.cs
Description : Manages the persistent debug log messages for in-game testing.
Author : Seth Hazelwood-Bradley
Mail : seth.hazelwoodbradley@mds.ac.nz
**************************************************************************/

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugLog : MonoBehaviour
{
    // Variables
    public Text logText; // Reference to the UI Text component
    public int maxMessages = 5; // Maximum number of messages to display

    private List<string> messageList = new List<string>(); // List to store messages

    // Code segment name 
    // --- Initialization
    void Start()
    {
        logText.text = ""; // Clear log at the start
    }

    // Code segment name 
    // --- Add Message
    public void AddMessage(string message)
    {
        // Add the new message to the list
        messageList.Add(message);

        // Check if the number of messages exceeds the limit
        if (messageList.Count > maxMessages)
        {
            // Remove the oldest message
            messageList.RemoveAt(0);
        }

        // Update the displayed log
        UpdateLogDisplay();
    }

    // Code segment name 
    // --- Update Log Display
    private void UpdateLogDisplay()
    {
        logText.text = ""; // Clear the current displayed text
        foreach (string msg in messageList)
        {
            logText.text += msg + "\n"; // Append each message to the log text
        }
    }
}
