using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public float range;
    public float speed;
    public int health;

    void Update()
    {
        float dist = Vector3.Distance(EnemySpawner.player.position, transform.position);

        if (dist <= range)
        {
            transform.position = Vector3.MoveTowards(transform.position, EnemySpawner.player.transform.position, Time.deltaTime);
        }
    }

    /// <summary>
    /// Runs when enemy is hit
    /// </summary>
    public void Hit()
    {
        health--;

        GameManager.UpdateHighScore(GameManager.highScore + 1);

        if (health <= 0) 
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
