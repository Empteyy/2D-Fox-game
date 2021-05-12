using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public bool isRight = true;
    public float speed = 0.3f;
    Vector3 pointAPosition;
    Vector3 pointBPosition;
    // Use this for initialization
    void Start()
    {
        pointAPosition = new Vector3(pointA.position.x, 0, 0);
        pointBPosition = new Vector3(pointB.position.x, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 thisPosition = new Vector3(transform.position.x, 0, 0);
        if (isRight)
        {
            transform.position = Vector3.MoveTowards(transform.position, pointB.position, speed);
            if (thisPosition.Equals(pointBPosition))
            {
                //Debug.Log ("Position b");
                isRight = false;
                Quaternion rotation = transform.rotation;
                rotation.y = 0;//(rotation.y == 0 ? 180 : 0);
                transform.rotation = rotation;
              
            }
            
        }
        
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, pointA.position, speed);
            if (thisPosition.Equals(pointAPosition))
            {
                //Debug.Log ("Position a");
                isRight = true;
                Quaternion rotation = transform.rotation;
                rotation.y = 180;//(rotation.y == 180 ? 0 : 180);
                transform.rotation = rotation;
            }
            
        }
    }



    
}   

