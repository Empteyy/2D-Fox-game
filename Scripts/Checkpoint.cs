using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Checkpoint : MonoBehaviour
{
    public bool checkpointAchieved = false;
    GameObject player;
    public int checkpointCode;




    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            checkpointCode = 0;
            Debug.Log("Checkpoint set to 0");
        }



        if (Input.GetKeyDown(KeyCode.O))
        {
            checkpointCode = 1;
            Debug.Log("Checkpoint set to 1");
        }




        if (Input.GetKeyDown(KeyCode.P))
        {
            checkpointCode = 2;
            Debug.Log("Checkpoint set to 2");
        }
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            checkpointAchieved = true;
            PlayerPrefs.SetInt("checkpoint", checkpointCode);
        }
    }
}