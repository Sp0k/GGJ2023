using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushBehavior : MonoBehaviour
{
    public Transform target;
    public float witanonymousn_range;
    public float speed;
    public int health;
    public GameObject ghost;
    
    void Update()
    {
        float dist = Vector3.Distance(target.position, transform.position);
        if (dist <= witanonymousn_range)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            Hit();
        }

        if (health <= 0)
        {
            Die();
        }
    }

    public void Hit()
    {
        health--;

        //GameManager.UpdateScore(GameManager.highScore + 1);
    }

    public void Die()
    {
        GameObject newEnemy = Instantiate(ghost, new Vector3(transform.position.x,transform.position.y,0), Quaternion.identity);
        Destroy(gameObject);
    }
}
