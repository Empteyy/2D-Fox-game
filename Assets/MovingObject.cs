using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovingObject : MonoBehaviour
{
    public Vector3 destination;
    public float speed;
    Vector3 source;
    Vector3 moveTo;
    public Vector3 destroyObject;
    bool skksks = false;


    // Use this for initialization
    void Start()
    {
        source = transform.position;
        moveTo = destination;
    }
    private void Update()
    {if (skksks == true)
        {            
                Debug.Log("Collided");
                transform.position = Vector3.MoveTowards(transform.position, moveTo, Time.deltaTime * speed);
                if (transform.position == destination)
                    moveTo = source;
                if (transform.position == source)
                    moveTo = destination;

                if (transform.position == destroyObject)
                {
                    Destroy(this.gameObject);
                }            
        }   
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player") {
            skksks = true;
        }
    }
}







