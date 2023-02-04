using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    public Player player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.lifeCounter--;
    }

    public void LoseLife()
    {
        player.lifeCounter--;

        if (player.lifeCounter <= 0)
        {
            Die();
        }
    }

    public void Die()
    {

    }
}
