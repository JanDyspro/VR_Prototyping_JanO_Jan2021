using System;
using BNG;
using DG.Tweening;
using UnityEngine;
using Valve.VR;

public class CornerClimb : MonoBehaviour
{
    [SerializeField] private PressurePlate pressurePlate = null;
    [SerializeField] private Vector3 targetLocation = Vector3.zero;
    [SerializeField] private GameObject player = null;
    [SerializeField] private InputBridge _inputBridge;
    [SerializeField] private HandController _handControllerLeft;
    [SerializeField] private HandController _handControllerRight;

    [HideInInspector] public bool goingToMove = false;
    

    private void Update()
    {
        if (goingToMove)
        {
            Move();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (pressurePlate.isPressed && other.tag == "Head")
        {
            goingToMove = true;
            Debug.Log("Moved");
            
        }
    }

    public void Move()
    {
        _inputBridge.RightGrip = 0;
        _inputBridge.LeftGrip = 0;
        _handControllerLeft.GripAmount = 0;
        _handControllerRight.GripAmount = 0;
        player.transform.position = targetLocation;
        goingToMove = false;
    }
}
