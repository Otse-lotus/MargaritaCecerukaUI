using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : Weapon
{
    public Axe()
    {
        name = "Axe";
    }

    public override int GetDamage()
    {
        return 25;
    }
}

