using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{

    public Transform target;
    public float witanonymousn_range;
    public float speed;
    public int health;

    void Update()
    {
        float dist = Vector3.Distance(target.position, transform.position);
        if (dist <= witanonymousn_range)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime);

        }
    }

    public void Hit()
    {
        health--;

        if (health <= 0) 
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
