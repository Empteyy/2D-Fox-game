using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public GameObject Door;
    public GameObject Player;
    public Sprite openSprite;
    public bool doorOpen;
    public int coins;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && doorOpen)
        {
                WalkTroughDoor();
        }
    }

    void WalkTroughDoor()
    {
        
        {
            Player.transform.position = new Vector2(Door.transform.position.x, Door.transform.position.y);
        }
    }

    public void UnlockDoor()
    {
        doorOpen = true;
        this.gameObject.GetComponent<SpriteRenderer>().sprite = openSprite;
    }

}
