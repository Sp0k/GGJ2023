using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public float witanonymousn_range;
    public float speed;
    public int health;

    void Update()
    {
        float dist = Vector3.Distance(EnemySpawner.player.position, transform.position);

        if (dist <= witanonymousn_range)
        {
            transform.position = Vector3.MoveTowards(transform.position, EnemySpawner.player.transform.position, Time.deltaTime);

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
        Debug.Log("enemy Dies");

        Destroy(gameObject);
    }
}
