using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Enemy : Character
{
    public string name;

    public Enemy(string enemyName, int hp, int dmg)
    {
        name = enemyName;
        health = hp;
        damage = dmg;
    }
}
