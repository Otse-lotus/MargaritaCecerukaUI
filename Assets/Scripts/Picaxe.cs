using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picaxe : Weapon
{
   
        public Picaxe()
        {
            name = "Pickaxe";
        }

        public override int GetDamage()
        {
            return 15;
        }
    
}

