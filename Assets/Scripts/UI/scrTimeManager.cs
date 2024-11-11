using UnityEngine;
using System;

public class scrTimeManager : MonoBehaviour
{
    public static scrTimeManager Instance { get; private set; }

    public float totalShiftTime = 300f; // 5 minutes real time = 8 hours game time
    private float currentTime;

    public event Action OnShiftEnd;

    private void Awake()
    {
        Instance = this;
        currentTime = totalShiftTime;
    }

    private void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            UpdateTimeDisplay();

            if (currentTime <= 0)
            {
                OnShiftEnd?.Invoke();
            }
        }
    }

    private void UpdateTimeDisplay()
    {
        float hoursToDisplay = Mathf.Lerp(8, 0, 1 - (currentTime / totalShiftTime));
        TimeSpan timeSpan = TimeSpan.FromHours(hoursToDisplay);
        if (scrUIManager.Instance != null)
        {
            scrUIManager.Instance.timerText.text = timeSpan.ToString(@"hh\:mm");
        }
    }
}