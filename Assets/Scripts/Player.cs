using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    public bool hasShield = false;
    public bool shieldBroken = false;

    public void ToggleShield(bool value)
    {
        hasShield = value;
    }
}
