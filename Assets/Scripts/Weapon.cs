using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon
{
    public string name;

    public void ShowName()
    {
        Debug.Log("Weapon: " + name);
    }

    public abstract int GetDamage();
}

