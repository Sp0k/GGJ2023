using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldScript : MonoBehaviour
{
    Vector3 pos;
    Quaternion rot;

    void Awake()
    {
        pos = transform.position;
        rot = transform.rotation;
    }

    void Update()
    {
        transform.position = pos;
        transform.rotation = rot;
    }
}
