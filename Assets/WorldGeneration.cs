using UnityEngine;

public class WorldGeneration : MonoBehaviour
{
    public GameObject[] rooms;
    public Transform player;

    public int levelCount = 0;

    private System.Random random;

    void Start()
    {
        GameObject initialRoom = Instantiate(rooms[0]);
        initialRoom.transform.position = Vector3.zero;

        GameObject nextRoom = Instantiate(rooms[random.Next(1, rooms.Length)]);
        int x = 0; // levelLength / 2
        nextRoom.transform.position = new Vector3(x, 0);

        levelCount += 2;
    }

    void Update()
    {
        // Check if player entered next level:
        //     block previous level
        //     spawn random new level
        //     change position using levelCount
        //     add level to level count
    }
}
