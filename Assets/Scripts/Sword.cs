using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Sword : Weapon
{
    public Sword()
    {
        name = "Diamon Sword";
    }

    public override int GetDamage()
    {
        return 20;
    }
}

