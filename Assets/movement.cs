using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            myRigidbody.transform.position = new Vector3(myRigidbody.transform.position.x, myRigidbody.transform.position.y + moveSpeed * Time.deltaTime, myRigidbody.transform.position.z);
            myRigidbody.transform.Translate(Vector3.forward * Time.deltaTime);

        }
        if(Input.GetKey(KeyCode.DownArrow) == true)
        {
            //down
            myRigidbody.transform.position = new Vector3(myRigidbody.transform.position.x, myRigidbody.transform.position.y - moveSpeed * Time.deltaTime, myRigidbody.transform.position.z);
            myRigidbody.transform.Translate(Vector3.forward * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //left
            myRigidbody.transform.position = new Vector3(myRigidbody.transform.position.x - moveSpeed * Time.deltaTime, myRigidbody.transform.position.y, myRigidbody.transform.position.z);
            myRigidbody.transform.Translate(Vector3.forward * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //left
            myRigidbody.transform.position = new Vector3(myRigidbody.transform.position.x + moveSpeed * Time.deltaTime, myRigidbody.transform.position.y, myRigidbody.transform.position.z);
            myRigidbody.transform.Translate(Vector3.forward * Time.deltaTime);
        }

    }
}
