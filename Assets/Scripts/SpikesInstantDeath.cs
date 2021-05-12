using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SpikesInstantDeath : MonoBehaviour
{
    private float waitTime = 0f;



    public void Update()
    {
        waitTime -= Time.deltaTime;
    }



    private void OnTriggerStay(Collider other)
    {



        if (other.gameObject.tag == "Player" && waitTime <= 0)
        {
            other.gameObject.GetComponent<PlayerMovement>().health -= 100;
            waitTime = 0f;
        }
    }
}