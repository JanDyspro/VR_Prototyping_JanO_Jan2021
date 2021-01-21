using System;
using DG.Tweening;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    
    [SerializeField] private GameObject door = null;

    [SerializeField] private Vector3 targetPosition = Vector3.zero;
    private Vector3 startPosition;

    [Range(1, 10), SerializeField] private float moveDuration = 1;

    [HideInInspector] public bool isPressed;

    private void Awake()
    {
        startPosition = door.transform.position;
    }

    public void OpenDoor()
    {
        door.transform.DOMove(targetPosition, moveDuration);
    }

    public void CloseDoor()
    {
        door.transform.DOMove(startPosition, moveDuration);
    }
    private void OnTriggerStay(Collider other)
    {
        OpenDoor();
        isPressed = true;
    }

    private void OnTriggerExit(Collider other)
    {
        CloseDoor();
        isPressed = false;
    }
}
