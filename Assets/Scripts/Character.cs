using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Character
{
    public int health;
    public int damage;

    public void TakeDamage(int amount)
    {
        health = health - amount;
    }

    public void Heal(int amount)
    {
        health = health + amount;
    }



    public void TakeDamage(int amount, bool ignoreShield)
    {
        if (ignoreShield)
        {
            health = health - amount;
        }
        else
        {
            health = health - (amount / 2);
        }
    }
}
