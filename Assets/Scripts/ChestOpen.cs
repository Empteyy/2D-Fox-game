using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestOpen : MonoBehaviour
{
    bool chestOpen = false;
    public Animator chestAnimator;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetButtonDown("Interact"))
            {
                openingChest();
            }
        }
    }

    void openingChest()
    {
        chestOpen = true;
        this.GetComponent<Animation>().Play("Chest"); 
    }

    
}
