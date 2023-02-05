using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public float range;
    public float speed;
    public int health;

    public SpriteRenderer renderer;

    private void Awake()
    {
        renderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float oldPos = transform.position.x;
        float dist = Vector3.Distance(EnemySpawner.player.position, transform.position);


        if (dist <= range)
        {
            transform.position = Vector3.MoveTowards(transform.position, EnemySpawner.player.transform.position, Time.deltaTime);

            float direction = oldPos - transform.position.x;

            if (direction < 0)
                renderer.flipX = true;
            else if (direction > 0)
                renderer.flipX = false;
        }
    }

    /// <summary>
    /// Runs when enemy is hit
    /// </summary>
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
        Destroy(gameObject);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
