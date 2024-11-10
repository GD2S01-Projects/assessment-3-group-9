using Unity.VisualScripting;
using UnityEngine;


public interface IPatient
{
    public string sName { get; set; }
    public string sCondition { get; set; }
    public int iHealth { get; set; }
    public string sAccidentInfo { get; set; }

    // Patient Methods

    public string DisplayInfo()
    {
        return sAccidentInfo;
    }

    public string DescribeSymptoms()
    {
        string condition = sCondition;
        int severity = ReturnSeverity(iHealth);

        switch (condition)
        {
            case "Healthy":
                {
                    return "This patient is looking healthy.";
                }
            case "Bleeding":
                switch (severity)
                {
                    case 1: return "The patient is bleeding lightly.";
                    case 2: return "The patient is bleeding moderately.";
                    case 3: return "The patient is bleeding heavily.";
                    case 4: return "The patient is gushing blood everywhere.";
                    case 5: return "The patient has died of blood loss";
                    default: return "The patient is bleeding lightly.";
                }
            case "Sick":
                switch (severity)
                {
                    case 1: return "The patient is bruised lightly.";
                    case 2: return "The patient is bruised moderately.";
                    case 3: return "The patient bruises are extremely painful.";
                    case 4: return "The patient is covered in bruises";
                    case 5: return "The patient has died of shock";
                    default: return "The patient is bleeding lightly.";
                }
            case "HighBPM":
                switch (severity)
                {
                    case 1: return "The patient's chest hurts.";
                    case 2: return "The patient is feeling a lot of pressure around their chest.";
                    case 3: return "The patient is feeling dizzy and has a burning sensation around their heart.";
                    case 4: return "The patient is having a serious heart attack.";
                    case 5: return "The patient has died of a heart attack.";
                    default: return "This area is lightly bruised.";
                }
            case "BrokenBone":
                switch (severity)
                {
                    case 1: return "There is a small bone fracture in the patient.";
                    case 2: return "There is a large bone fracture in the patient.";
                    case 3: return "There is a bone pushing against the patient's skin.";
                    case 4: return "There is a bone piercing out of the patient's body.";
                    case 5: return "The patient has died due to internal bleeding";
                    default: return "There is a small bone fracture in this area.";
                }
            default:
                return "This area looks healthy.";
        }
    }

    private int ReturnSeverity(int _HealthPercentage)
    {
        int conditionSeverity = 1;
        if (_HealthPercentage < 75)
        {
            conditionSeverity = 1;
        }
        else if (_HealthPercentage > 75 && _HealthPercentage < 50)
        {
            conditionSeverity = 2;
        }
        else if (_HealthPercentage > 50 && _HealthPercentage < 25)
        {
            conditionSeverity = 3;
        }
        else if (_HealthPercentage > 25 && _HealthPercentage < 0)
        {
            conditionSeverity = 4;
        }
        else if (_HealthPercentage == 0)
        {
            conditionSeverity = 5;
        }
        return conditionSeverity;
    }
}

public class cChildPatient : MonoBehaviour, IPatient
{
    private float iTimer = 0.0f;

    private void Update()
    {
        if (bIsDead == false)
        {
            iTimer += Time.deltaTime;
            if (iTimer > 1.0f)
            {
                iHealth -= 1;
                iTimer = 0.0f;
            }

            if (iHealth <= 0)
            {
                bIsDead = true;
            }
        }
    }

    public string sName { get; set; }
    public string sCondition { get; set; }
    public int iHealth { get; set; }
    public string sAccidentInfo { get; set; }

    public bool bIsDead = false;
    public string DisplayInfo()
    {
        switch (sAccidentInfo)
        {
            case "CarCrash":
                {
                    return "Mummy and Daddy crashed their car and now I feel hurt";
                }
            case "MountainAccident":
                {
                    return "Me and my parents were going for a walk and I fell down the hill for a long time";
                }
            case "Attacked":
                {
                    return "A bad man hurt me";
                }
            case "Fight":
                {
                    return "I fought back against a bad bully but they hurt me a lot";
                }
            case "Exposed":
                {
                    return "I was outside for a long time when it was cold";
                }
            case "FellOver":
                {
                    return "I fell over badly and it hurts";
                }
            case "WorkAccident":
                {
                    return "null";
                }
            default:
                {
                    return "default case";
                }
        }
    }
}

public class cAdultPatient : MonoBehaviour, IPatient
{
    private float iTimer = 0.0f;

    private void Update()
    {
        if (bIsDead == false)
        {
            iTimer += Time.deltaTime;
            if (iTimer > 1.0f)
            {
                iHealth -= 1;
                iTimer = 0.0f;
            }

            if (iHealth <= 0)
            {
                bIsDead = true;
            }
        }
    }

    public string sName { get; set; }
    public string sCondition { get; set; }
    public int iHealth { get; set; }
    public string sAccidentInfo { get; set; }

    public bool bIsDead = false;
    public string DisplayInfo()
    {
        switch (sAccidentInfo)
        {
            case "CarCrash":
                {
                    return "Some asshole came out of nowhere and crashed into my car";
                }
            case "MountainAccident":
                {
                    return "I was on a hiking trail and lost my footing, fell for quite a ways";
                }
            case "Attacked":
                {
                    return "I was assaulted and robbed while walking back home";
                }
            case "Fight":
                {
                    return "Got into a fight with some douche who couldn't keep their mouth shut";
                }
            case "Exposed":
                {
                    return "Was out in the cold for long time.";
                }
            case "FellOver":
                {
                    return "Tripped up on my shoe-laces and hit the ground pretty hard...";
                }
            case "WorkAccident":
                {
                    return "Was operating on some machinery at work and had a bit of a accident";
                }
            default:
                {
                    return "default case";
                }
        }
    }

}
