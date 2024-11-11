using UnityEngine;
using UnityEngine.UI;

public class scrPatientIndicator : MonoBehaviour
{
    private Image backgroundImage;
    private Button button;
    private scrPatient patient;

    private void Awake()
    {
        backgroundImage = GetComponent<Image>();
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    public void Initialize(scrPatient patient)
    {
        this.patient = patient;
        backgroundImage.color = Color.black;
    }

    public void SetSelected(bool selected)
    {
        backgroundImage.color = selected ? Color.red : Color.black;
    }

    private void OnClick()
    {
        scrUIManager.Instance.ShowPatientInfo(patient);
    }
}