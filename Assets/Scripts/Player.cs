using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


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

        lifeSprites[lifeCounter].SetActive(true);

        if (lifeCounter <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        SceneManager.LoadScene(2);
    }
}
