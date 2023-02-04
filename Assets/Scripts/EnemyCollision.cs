using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer != 10)
            return; 

        collision.gameObject.GetComponent<Player>().Hit();

        Destroy(gameObject);
    }
}
