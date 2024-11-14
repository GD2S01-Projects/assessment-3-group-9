using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MedicalPractitionerNamespace;

public class DoctorUIManager : MonoBehaviour
{
    public DoctorFactory doctorFactory;

    // Button references
    public Button GPButton;
    public Button SurgeonButton;
    public Button CardiologistButton;
    public Button OrthopedistButton;
    public Button DermatologistButton;

    // Dictionary to store doctors by specialization
    private Dictionary<string, Doctor> doctorsBySpecialization = new Dictionary<string, Doctor>();

    private void Start()
    {
        // Initialize DoctorFactory and create doctors
        doctorFactory = new DoctorFactory();
        AssignDoctorsToSpecializations();

        // Set up button click events
        GPButton.onClick.AddListener(() => OnDoctorButtonClicked("General Practitioner"));
        SurgeonButton.onClick.AddListener(() => OnDoctorButtonClicked("Emergency Physician"));
        CardiologistButton.onClick.AddListener(() => OnDoctorButtonClicked("Cardiologist"));
        OrthopedistButton.onClick.AddListener(() => OnDoctorButtonClicked("Orthopedic Surgeon"));
        DermatologistButton.onClick.AddListener(() => OnDoctorButtonClicked("Dermatologist"));

        // Update button colors based on initial availability
        UpdateButtonColors();
    }

    private void AssignDoctorsToSpecializations()
    {
        // Cast each created practitioner to Doctor and assign to specializations
        doctorsBySpecialization["General Practitioner"] = (Doctor)doctorFactory.CreateMedicalPractitioner();
        doctorsBySpecialization["Emergency Physician"] = (Doctor)doctorFactory.CreateMedicalPractitioner();
        doctorsBySpecialization["Cardiologist"] = (Doctor)doctorFactory.CreateMedicalPractitioner();
        doctorsBySpecialization["Orthopedic Surgeon"] = (Doctor)doctorFactory.CreateMedicalPractitioner();
        doctorsBySpecialization["Dermatologist"] = (Doctor)doctorFactory.CreateMedicalPractitioner();
    }

    private void OnDoctorButtonClicked(string specialization)
    {
        if (doctorsBySpecialization.TryGetValue(specialization, out Doctor doctor))
        {
            if (doctor.isAvailable)
            {
                Debug.Log($"{doctor.sName} is available for {specialization}.");
            }
            else
            {
                Debug.Log($"{doctor.sName} is currently unavailable.");
            }
        }
    }

    private void UpdateButtonColors()
    {
        SetButtonColor(GPButton, doctorsBySpecialization["General Practitioner"].isAvailable);
        SetButtonColor(SurgeonButton, doctorsBySpecialization["Emergency Physician"].isAvailable);
        SetButtonColor(CardiologistButton, doctorsBySpecialization["Cardiologist"].isAvailable);
        SetButtonColor(OrthopedistButton, doctorsBySpecialization["Orthopedic Surgeon"].isAvailable);
        SetButtonColor(DermatologistButton, doctorsBySpecialization["Dermatologist"].isAvailable);
    }

    private void SetButtonColor(Button button, bool isAvailable)
    {
        Color color = isAvailable ? Color.green : Color.red;
        ColorBlock colorBlock = button.colors;
        colorBlock.normalColor = color;
        colorBlock.selectedColor = color;
        button.colors = colorBlock;
    }

    private void Update()
    {
        // Continuously update button colors based on doctor availability
        UpdateButtonColors();
    }
}
