using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class WorldGeneration : MonoBehaviour
{
    public GameObject[] rooms;
    public Transform player;
    public List<GameObject> roomsList;
    public int roomSize = 20;

    private int roomCount = 0;

    private System.Random random;

    void Start()
    {
        random = new System.Random();
        roomsList = new List<GameObject>();

        GameObject initialRoom = Instantiate(rooms[0]);
        initialRoom.transform.position = new Vector3(0, 0, 1);
        roomsList.Add(initialRoom);

        GameObject nextRoom = Instantiate(rooms[RandomIndex()]);
        nextRoom.transform.position = new Vector3(roomSize, 0, 1);
        roomsList.Add(nextRoom);

        roomCount += 2;
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

            roomsList.Add(Instantiate(rooms[RandomIndex()]));
            roomsList[roomsList.Count - 1].transform.position = new Vector3(roomCount * roomSize, 0, 1);
            roomCount++;
        }

        // if leave room
        //     block previous room
    }

    int RandomIndex() => random.Next(1, rooms.Length - 1);
}
