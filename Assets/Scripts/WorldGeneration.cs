using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class WorldGeneration : MonoBehaviour
{
    public GameObject[] rooms;
    public Transform player;
    public List<GameObject> roomsList;
    public float roomSize = 20;
    public int roomCount = 0;

    public int currentRoom = 0;

    private int sameRoomCounter = 0;
    private int currentRoomIndex = 0;

    private System.Random random;

    void Start()
    {
        random = new System.Random();
        roomsList = new List<GameObject>();

        GenerateRoom(0);
        GenerateRoom(roomSize);
    }

    void Update()
    {
        if (player.position.x > (roomSize / 2) + ((roomCount - 2) * roomSize) -1)
        {
            if (roomsList.Count > 2)
            {
                Destroy(roomsList[0]);
                roomsList.RemoveAt(0);
            }

            GenerateRoom(roomCount * roomSize);
        }

        if (player.position.x > (roomSize / 2) + (currentRoom * roomSize) + 0.5f)
        {
            BoxCollider2D[] colliders = roomsList[0].GetComponents<BoxCollider2D>();

            foreach (BoxCollider2D collider2D in colliders)
            {
                collider2D.enabled = true;
            }

            currentRoom++;
        }
    }

    private void GenerateRoom(float x)
    {
        if (sameRoomCounter == 3)
        {
            sameRoomCounter = 0;
            currentRoomIndex = RandomIndex();
        }

        sameRoomCounter++;
        GameObject nextRoom = Instantiate(rooms[currentRoomIndex], new Vector3(x, 0, 1), Quaternion.identity);

        roomsList.Add(nextRoom);
        roomCount++;
    }

    int RandomIndex() => random.Next(1, rooms.Length - 1);
}
