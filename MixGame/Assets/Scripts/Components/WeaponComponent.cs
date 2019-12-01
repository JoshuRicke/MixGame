using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponComponent : MonoBehaviour, IWeapon
{
    private IWeaponSystem WeaponSystem { get; set; }

    public void UseWeaponPrimary()
    {
        WeaponSystem.UseWeapon(FireMode.Primary);
    }

    public void UseWeaponSecondary()
    {
        WeaponSystem.UseWeapon(FireMode.Secondary);
    }

    // Start is called before the first frame update
    void Start()
    {
        WeaponSystem = new WeaponSystem();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
