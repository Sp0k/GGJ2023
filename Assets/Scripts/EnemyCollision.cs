using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = FindObjectOfType<Player>();

        player.Hit(gameObject);
    }
}
