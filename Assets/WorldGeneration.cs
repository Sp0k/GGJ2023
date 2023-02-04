using System.Collections.Generic;
using UnityEngine;

public class WorldGeneration : MonoBehaviour
{
    public GameObject[] rooms;
    public Transform player;
    public List<GameObject> roomsList;

    private int roomCount = 0;

    private System.Random random;

    void Start()
    {
        random = new System.Random();
        roomsList = new List<GameObject>();

        GameObject initialRoom = Instantiate(rooms[0]);
        initialRoom.transform.position = Vector3.zero;
        roomsList.Add(initialRoom);

        GameObject nextRoom = Instantiate(rooms[RandomIndex()]);
        int x = 20; 
        nextRoom.transform.position = new Vector3(x, 0);
        roomsList.Add(nextRoom);

        roomCount += 2;
    }

    void Update()
    {
        if (player.position.x > 10 + ((roomCount - 1) * 20) -1)
        //if (player.position.x > )
        {
            // To do: block player from going back
            Destroy(roomsList[0]);
            roomsList.RemoveAt(0);
            roomsList.Add(Instantiate(rooms[RandomIndex()]));
            roomsList[1].transform.position = new Vector3(20 + ((roomCount - 2) * 40), 0);
            roomCount++;
        }
    }

    int RandomIndex() => random.Next(1, rooms.Length - 1);
}
