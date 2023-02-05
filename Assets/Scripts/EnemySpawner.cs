using System.Collections;
using UnityEditor.PackageManager;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public int maxEnemyCount = 5;

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
            if (enemyCount <= maxEnemyCount)
            {
                float x = Random.Range(-10f, 10);
                float y = Random.Range(-5f, 1f);

                while (Mathf.Sqrt((Mathf.Pow((player.position.x + x) - player.position.x, 2) + Mathf.Pow(y - player.position.y, 2))) < 4)
                {
                    x = Random.Range(-10f, 10);
                    y = Random.Range(-5f, 1f);
                }

                GameObject newEnemy = Instantiate(enemy, new Vector3(player.position.x + x, y, 0), Quaternion.identity);
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
