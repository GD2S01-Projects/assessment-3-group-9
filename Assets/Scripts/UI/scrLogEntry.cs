using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LogEntry : MonoBehaviour
{
    public TextMeshProUGUI timestampText;
    public TextMeshProUGUI messageText;

    public void Initialize(string timestamp, string message)
    {
        timestampText.text = timestamp;
        messageText.text = message;
    }
}