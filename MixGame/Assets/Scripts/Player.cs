using System;
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
    private List<IWeapon> WeaponComponents { get; set; }

    public int SelectedWeapon { get; set; }
    void Start()
    {
        _animator = gameObject.GetComponentInChildren<Animator>();
        WalkComponent = GetComponent<IWalk>();
        JumpComponent = GetComponent<IJump>();
        IdleComponent = GetComponent<IIdle>();
        WeaponComponents = new List<IWeapon>();
        WeaponComponents.AddRange(GetComponents<IWeapon>());
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
            if (Input.GetMouseButtonDown(1))
            {
                WeaponComponents[SelectedWeapon].UseWeaponPrimary();
            }
            if (Input.GetMouseButtonDown(2))
            {
                WeaponComponents[SelectedWeapon].UseWeaponSecondary();
            }
            if (Input.GetKey(KeyCode.V))
            {
                //Quick Meele
            }
            if (Input.GetKey(KeyCode.Q))
            {
                //Ultimate
            }
            if (Input.GetKey(KeyCode.E))
            {
                //PrimaryAbility
            }
            if (Input.GetKey(KeyCode.LeftShift))
            {
                //UtilityAbility
            }
            if (Input.GetKey(KeyCode.R))
            {
                //Reload
            }

        }
    }

    private void CreateComponents()
    {

    }


}
