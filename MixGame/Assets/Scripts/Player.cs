using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Player : NetworkBehaviour
{
    [SerializeField]
    private float _movementSpeed = 1;
    private Animator _animator;
    private IWalk WalkComponent { get; set; }

    void Start()
    {
        _animator = gameObject.GetComponentInChildren<Animator>();
        WalkComponent = GetComponent<IWalk>();
        CreateComponents();
    }

    // Update is called once per frame
    void Update()
    {
        if (isLocalPlayer)
        {

            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
            {
                _animator.SetTrigger("Walk");
                WalkComponent.Walk();
            }
            else { _animator.SetTrigger("Idle"); }
        }
    }

    private void CreateComponents()
    {

    }


}
