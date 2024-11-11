using UnityEngine;
using UnityEngine.UI;

public class scrRoomIndicator : MonoBehaviour
{
    public Image statusIndicator;
    public GameObject plusSign;
    public GameObject occupiedIcon;

    private string roomId;
    private bool isOccupied;
    private Button button;

    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    public void Initialize(string id)
    {
        roomId = id;
        SetOccupied(false);
    }

    public void SetOccupied(bool occupied)
    {
        isOccupied = occupied;
        statusIndicator.color = occupied ? Color.red : Color.green;
        plusSign.SetActive(!occupied);
        occupiedIcon.SetActive(occupied);
        button.interactable = !occupied;
    }

    public string GetRoomId() => roomId;

    private void OnClick()
    {
        if (!isOccupied)
        {
            Debug.Log($"Room {roomId} clicked");
        }
    }
}