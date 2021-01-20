using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Animation))]
public class PlayAnimation : MonoBehaviour
{
    [SerializeField] private Animation _animation = null;
    private void Awake()
    {
        if (_animation == null)
        {
            _animation = GetComponent<Animation>();
        }
    }

    public void PlayAnimationClip()
    {
        _animation.Play();
    }
}
