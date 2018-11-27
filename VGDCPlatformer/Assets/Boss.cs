using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour {
    public Respawn respawn;
    public Transform[] patrolPoints;
    public float speed;
    Transform currentPatrolPoint;
    int currentPatrolIntex;

    public Transform target;
    public float chaseRange;

    // Use this for initialization
    void Start()
    {
        currentPatrolIntex = 0;
        currentPatrolPoint = patrolPoints[currentPatrolIntex];

    }

    // Update is called once per frame
    void Update()
    {
        float distanceToTarget = Vector3.Distance(transform.position, target.position);
        if (distanceToTarget < chaseRange)
        {

            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Player")
        {
            respawn.Reload();
        }
        else if (collision.gameObject.tag == "environment")
        {
           // Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "CrushBlock")
        {
            speed = 1;
        }
    }
}