using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public float witanonymousn_range;
    public float speed;
    public int health;

    private Transform target;

    private void Start()
    {
        target = FindObjectOfType<Player>().transform;
    }

    void Update()
    {
        if (target == null)
            Debug.Log("Null");

        float dist = Vector3.Distance(target.position, transform.position);

        if (dist <= witanonymousn_range)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime);

        }
    }

    public void Hit()
    {
        health--;

        GameManager.UpdateScore(GameManager.highScore + 1);

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
