using System;
using BNG;
using DG.Tweening;
using UnityEngine;

public class CornerClimb : MonoBehaviour
{
    [SerializeField] private PressurePlate pressurePlate = null;
    [SerializeField] private Vector3 targetLocation = Vector3.zero;
    [SerializeField] private GameObject player = null;

    private void OnTriggerEnter(Collider other)
    {
        if (pressurePlate.isPressed)
        {
            player.transform.DOMove(targetLocation, 1);    
        }
    }
}
