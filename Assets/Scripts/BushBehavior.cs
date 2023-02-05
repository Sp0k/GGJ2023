using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushBehavior : MonoBehaviour
{
public GameObject ghost;

    public float range;
    public float speed;
    public int health;

    public void Update()
    {
        float dist = Vector3.Distance(EnemySpawner.player.position, transform.position);

        if (dist <= range)
        {
            transform.position = Vector3.MoveTowards(transform.position, EnemySpawner.player.position, Time.deltaTime);

        }
    }

    public void Hit()
    {
        health--;

        GameManager.IncrementScore();

        if (health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Instantiate(ghost, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
