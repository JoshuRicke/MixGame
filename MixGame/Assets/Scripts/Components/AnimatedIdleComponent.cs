using Engine.Components;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedIdleComponent : MonoBehaviour, IIdle, IAnimated
{
    public Animator Animator { get; set; }

    private int IdleHash { get; set; }

    // Use this for initialization
    void Start()
    {
        Animator = GetComponent<Animator>();
        IdleHash = Animator.StringToHash("Base.Idle");
    }

    public void Idle()
    {
        if (Animator.GetCurrentAnimatorStateInfo(0).fullPathHash == IdleHash) {
            return;
        }
        Animator.SetTrigger("Idle");
    }
}
