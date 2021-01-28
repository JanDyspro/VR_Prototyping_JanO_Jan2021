using System;
using System.Collections;
using DG.Tweening;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    [SerializeField] private PlayAnimation _playAnimation = null;
    [SerializeField] private Animation _animation = null;
    private void Awake()
    {
        if (_animation == null)
        {
            _animation = GetComponent<Animation>();
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Head")
        {
            _playAnimation.PlayAnimationClip();
        }
        
    }
}
