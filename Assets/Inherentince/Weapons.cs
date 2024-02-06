using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons
{
    private string weaponName;
    private int weaponStrenght;

  

    protected int WeaponStrenght { get => weaponStrenght; set => weaponStrenght = value; }
    protected string WeaponName { get => weaponName; set => weaponName = value; }

    protected virtual void TakeDamage(int damage)
    {
        WeaponStrenght -= damage;
    }
}
