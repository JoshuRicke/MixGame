public interface IFireMode
{
    WeaponType WeaponType { get; set; }
    int FireRate { get; set; }
    int Damage { get; set; }
    bool CanHarvest { get; set; }
}