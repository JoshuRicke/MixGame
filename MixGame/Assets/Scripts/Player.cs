﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Player : NetworkBehaviour
{
    private Animator _animator;
    private IWalk WalkComponent { get; set; }
    private IJump JumpComponent { get; set; }
    private IIdle IdleComponent { get; set; }
    void Start()
    {
        _animator = gameObject.GetComponentInChildren<Animator>();
        WalkComponent = GetComponent<IWalk>();
        JumpComponent = GetComponent<IJump>();
        IdleComponent = GetComponent<IIdle>();
        CreateComponents();
    }

    // Update is called once per frame
    void Update()
    {
        if (isLocalPlayer)
        {

            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
            {
                WalkComponent.Walk();
            }
            if (Input.GetKey(KeyCode.Space))
            {
                JumpComponent.Jump();
            }
            if (!Input.anyKeyDown && !Input.anyKey)
            {
                IdleComponent.Idle();
            }

        }
    }

    private void CreateComponents()
    {

    }


}
