using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject s_enemy1;

    private float swarmerInterval = 3.5f;
    public static int enemyCount = 2;
    public static bool maxEne = false;
    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(spawnEnemy(swarmerInterval, gameObject));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy) {
        
        
        while (!maxEne)
        {
            
            yield return new WaitForSeconds(interval);
         
            if(enemyCount<=5)
            {
            GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6f), 0), Quaternion.identity);
                enemyCount++;
                Debug.Log(enemyCount);
            } else {
                maxEne = true;
                break;
            }
            
          
        }
        
    }

}
