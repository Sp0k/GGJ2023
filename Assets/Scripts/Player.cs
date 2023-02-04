using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int lifeCounter = 3;
    public GameObject[] lifeSprites;

    /// <summary>
    /// Run when player is hit
    /// </summary>
    public void Hit()
    {
        lifeCounter--;

        Debug.Log("Life" + lifeCounter);

        // lifeSprites[lifeCounter].SetActive(false);
    }
}
