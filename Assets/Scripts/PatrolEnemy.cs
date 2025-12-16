
/*
* David Huerta
* Assignment 6
* Controls enemy patrol movement between two points.
*/
using UnityEngine;

public class PatrolEnemy : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public float speed = 2f;

    private Transform target;

    void Start()
    {
        target = pointB;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(
            transform.position,
            target.position,
            speed * Time.deltaTime
        );

        if (Vector3.Distance(transform.position, target.position) < 0.2f)
        {
            target = target == pointA ? pointB : pointA;
        }
    }
}

