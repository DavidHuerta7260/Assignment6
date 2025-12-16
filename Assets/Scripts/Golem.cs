/*
* David Huerta
* Assignment 6
* Enemy subclass that takes damage and performs attacks.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem : Enemy
{
    protected int damage;

    protected override void Awake()
    {
        base.Awake();
        health = 120;
        GameManager.Instance.score += 2;
    }

    
    protected override void Attack()
    {
        Debug.Log("Golem attacks!");
    }

    public override void TakeDamage(int amount)
    {
        Debug.Log("Golem took " + amount + " point of damage");
        health -= amount;

        if (health <= 0)
        {
            Debug.Log("Golem defeated");
            Destroy(gameObject);
        }
    }

}

