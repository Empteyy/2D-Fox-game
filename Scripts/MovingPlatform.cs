using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{

    public Vector3 destination;
    public float speed;
    Vector3 source;
    Vector3 moveTo;

    // Use this for initialization
    void Start()
    {
        source = transform.position;
        moveTo = destination;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, moveTo, Time.deltaTime * speed);
        if (transform.position == destination)
            moveTo = source;
        if (transform.position == source)
            moveTo = destination;
    }
}
