using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class spike : MonoBehaviour
{
    private float waitTime = 1.0f;



    public void Update()
    {
        waitTime -= Time.deltaTime;
    }



    private void OnTriggerStay(Collider other)
    {



        if (other.gameObject.tag == "Player" && waitTime <= 0)
        {
            other.gameObject.GetComponent<PlayerMovement>().health -= 5;
            waitTime = 1.0f;
        }
    }
}