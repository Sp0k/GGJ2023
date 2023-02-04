using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int lifeCounter = 3;
    public GameObject[] lifeSprites;

    public void Hit(GameObject enemy)
    {
        lifeCounter--;

        Debug.Log(lifeCounter);

        // lifeSprites[lifeCounter].SetActive(false);

        enemy.GetComponent<EnemyBehavior>().Die();
    }
}
