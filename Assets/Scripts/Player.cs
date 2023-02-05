using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;


public class Player : MonoBehaviour
{
    public int lifeCounter = 3;
    public GameObject[] lifeSprites;
    //private GameObject startTransition; 

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
        //startTransition.SetActive(true);
        SceneManager.LoadScene(2);
    }

    private void disableStartScreen() {
        
    }

}
