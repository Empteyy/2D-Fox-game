using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            //Add 1 to points.
            other.gameObject.GetComponent<PlayerMovement>().coins += 1;
            Destroy(this.gameObject);
        }
    }
}

