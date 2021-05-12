using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Vector2 destination;
    
    public float speed = 0.5f;
    public bool move = true;


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Vector2 pos = transform.position;
            //pos.y = -25;
            //transform.Translate(Vector2.down * Time.deltaTime * 0.01f, Space.World);

            gameObject.transform.Translate(destination * Time.deltaTime * 5f, Space.World);

            //(transform.position, pos, Time.deltaTime * 2.0f);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Destroy(this.gameObject);
        
    }
}
