using UnityEngine;
using TMPro;

public class scrLogEntry : MonoBehaviour
{
    public TextMeshProUGUI timestampText;
    public TextMeshProUGUI messageText;

    public void Initialize(string timestamp, string message)
    {
        timestampText.text = timestamp;
        messageText.text = message;
    }
}
