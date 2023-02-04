using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{

    public Transform target;
    public float witanonymousn_range;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
            float dist = Vector3.Distance(target.position, transform.position);
            if(dist<=witanonymousn_range){
                transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime);
            
        }
        
    }
}
