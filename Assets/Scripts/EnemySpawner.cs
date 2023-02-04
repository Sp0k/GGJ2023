using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;

    private float swarmerInterval = 3.5f;
    public static int enemyCount = 2;
    public static bool maxEnemy = false;

    void Start()
    {
        StartCoroutine(spawnEnemy(swarmerInterval, enemy));
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        while (!maxEnemy)
        {
            if (enemyCount <= 5)
            {
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
