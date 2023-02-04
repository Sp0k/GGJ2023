using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class WorldGeneration : MonoBehaviour
{
    public GameObject[] rooms;
    public Transform player;
    public List<GameObject> roomsList;
    public float roomSize = 20;

    private int roomCount = 0;

    private System.Random random;

    void Start()
    {
        random = new System.Random();
        roomsList = new List<GameObject>();

        GameObject initialRoom = Instantiate(rooms[0]);
        initialRoom.transform.position = new Vector3(0, 0, 1);
        roomsList.Add(initialRoom);
        roomCount++;

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

        // if leave room
        //     block previous room
    }

    private void GenerateRoom(float x)
    {
        GameObject nextRoom = Instantiate(rooms[RandomIndex()]);
        nextRoom.transform.position = new Vector3(x, 0, 1);

        roomsList.Add(nextRoom);
        roomCount++;
    }

    int RandomIndex() => random.Next(1, rooms.Length - 1);
}
