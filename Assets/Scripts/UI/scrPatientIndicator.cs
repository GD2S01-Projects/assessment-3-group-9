using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PatientIndicator : MonoBehaviour
{
    private Image backgroundImage;
    private Button button;
    private string patientId;

    private void Awake()
    {
        backgroundImage = GetComponent<Image>();
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    public void Initialize(string id)
    {
        patientId = id;
        backgroundImage.color = Color.black;
    }

    public void SetSelected(bool selected)
    {
        backgroundImage.color = selected ? Color.red : Color.black;
    }

    private void OnClick()
    {
        UIManager.Instance.ShowPatientInfo(patientId);
    }
}