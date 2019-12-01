using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

public interface IWeaponSystem
{
    void UseWeapon(FireMode fireMode);

    List<FireMode> FireModes { get; set; }
    WeaponType WeaponType { get; set; }
    int FireRate { get; set; }
    int Damage { get; set; }
    bool CanHarvest { get; set; }

}