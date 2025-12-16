using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private float speed;

    public void Init(float speed)
    {
        this.speed = speed;
    }
}
