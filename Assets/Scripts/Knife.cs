using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : Weapons
{
    protected override void TakeDamage(int damage)
    {
        damage += 10;

        //base.TakeDamage(damage);  // don't always have to go to base class 
    }
}
