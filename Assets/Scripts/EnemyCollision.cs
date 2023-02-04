using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    public movement player;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.lifeCounter--;
        Debug.Log(player.lifeCounter);
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
