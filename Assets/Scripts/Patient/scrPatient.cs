using UnityEngine;

public class scrPatient : MonoBehaviour
{
    public string patientName { get; set; }

    //# PartID = 0
    public string patientHeadCondition { get; set; }
    public float patientHeadState { get; set; }

    //# PartID = 1
    public string patientBodyCondition { get; set; }
    public float patientBodyState { get; set; }
        
    //# PartID = 2
    public string patientLeftArmCondition { get; set; }
    public float patientLeftArmState { get; set; }

    //# PartID = 3
    public string patientRightArmCondition { get; set; }
    public float patientRightArmState { get; set; }

    //# PartID = 4
    public string patientLeftLegCondition { get; set; }
    public float patientLeftLegState { get; set; }

    //# PartID = 5
    public string patientRightLegCondition { get; set; }
    public float patientRightLegState { get; set; }


    // Method to describe symptoms
    public string DescribeSymptoms(int _PartID)
    {
        string condition = "";
        int severity = 0;
        switch (_PartID)
        {
            case (0): condition = patientHeadCondition; severity = ReturnSeverity(patientHeadState);  break;
            case (1): condition = patientBodyCondition; severity = ReturnSeverity(patientBodyState); break;
            case (2): condition = patientLeftArmCondition; severity = ReturnSeverity(patientLeftArmState); break;
            case (3): condition = patientRightArmCondition; severity = ReturnSeverity(patientRightArmState); break;
            case (4): condition = patientLeftLegCondition; severity = ReturnSeverity(patientLeftLegState); break;
            case (5): condition = patientRightLegCondition; severity = ReturnSeverity(patientRightLegState); break;
        }

        switch (condition)
        {
            case "Healthy":
                {
                    switch (severity)
                    {
                        case 1: return "This area is looking healthy.";
                        case 2: return "This area is looking healthy.";
                        case 3: return "This area is looking healthy.";
                        case 4: return "This area is looking healthy.";
                        default: return "This area is looking healthy.";
                    }
                }
            case "Bleeding":
                switch (severity)
                {
                    case 1: return "This area is bleeding lightly.";
                    case 2: return "This area is bleeding moderately.";
                    case 3: return "This area is bleeding heavily.";
                    case 4: return "This area is gushing blood everywhere.";
                    default: return "This area is bleeding lightly.";
                }
            case "Bruised":
                switch (severity)
                {
                    case 1: return "This area is lightly bruised.";
                    case 2: return "This area is moderately bruised.";
                    case 3: return "This area is heavily bruises.";
                    case 4: return "This area is agonizingly swollen with dark bruises.";
                    default: return "This area is lightly bruised.";
                }
            case "Frostbite":
                switch (severity)
                {
                    case 1: return "The area is cold to the touch.";
                    case 2: return "The area is a bright red, and is quite cold.";
                    case 3: return "The area is pale, very cold, and has formed blisters.";
                    case 4: return "The area is a deep black and is nearly rock solid.";
                    default: return "This area is cold to the touch.";
                }
            case "Broken Bone":
                switch (severity)
                {
                    case 1: return "There is a small bone fracture in this area.";
                    case 2: return "There is a large bone fracture in this area.";
                    case 3: return "There is a bone pushing against the area.";
                    case 4: return "There is a bone piercing out of the skin in this area.";
                    default: return "There is a small bone fracture in this area.";
                }
            default:
                return "This area looks healthy.";
        }
    }

    private int ReturnSeverity(float _HealthPercentage)
    {
        int conditionSeverity = 1;
        if (_HealthPercentage < 75f)
        {
            conditionSeverity = 1;
        }
        else if (_HealthPercentage > 75f && _HealthPercentage < 50f)
        {
            conditionSeverity = 2;
        }
        else if (_HealthPercentage > 50f && _HealthPercentage < 25f)
        {
            conditionSeverity = 3;
        }
        else if (_HealthPercentage > 25f && _HealthPercentage < 0f)
        {
            conditionSeverity = 4;
        }
        return conditionSeverity;
    }
}
