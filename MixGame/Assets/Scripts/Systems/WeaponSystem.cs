using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

public class WeaponSystem : IWeaponSystem
{
    public List<FireMode> FireModes { get; set}
    public WeaponType WeaponType { get; set; }
    public int FireRate { get; set; }
    public int Damage { get; set; }
    public bool CanHarvest { get; set; }

    public void UseWeapon(FireMode fireMode)
    {
        throw new System.NotImplementedException();
    }
}