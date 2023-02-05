using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    const int PLAYER_LAYER = 10;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer != PLAYER_LAYER)
            return; 

        collision.gameObject.GetComponent<Player>().Hit();

        Destroy(gameObject);
    }
}
