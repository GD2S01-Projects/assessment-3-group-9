using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RoomIndicator : MonoBehaviour
{
    public Image statusIndicator;
    public GameObject plusSign;
    public GameObject occupiedIcon;

    private string roomId;
    private bool isOccupied;

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
    }

    public string GetRoomId() => roomId;
}