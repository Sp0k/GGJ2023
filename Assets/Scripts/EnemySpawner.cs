using System.Collections;
using UnityEditor.PackageManager;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;

    private float swarmerInterval = 3.5f;
    public static int enemyCount = 2;
    public static bool maxEnemy = false;

    public static Transform player;

    void Start()
    {
        player = FindAnyObjectByType<Player>().transform;

        StartCoroutine(spawnEnemy(swarmerInterval, enemy));
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        while (!maxEnemy)
        {
            if (enemyCount <= 5)
            {
                Debug.Log("Enemy Spawned");
                GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6f), 0), Quaternion.identity);
                enemyCount++;
            }
            else
            {
                maxEnemy = true;
                break;
            }

            yield return new WaitForSeconds(interval);
        }
    }
}
