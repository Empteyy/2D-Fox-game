using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovementScript : MonoBehaviour
{
    public NavMeshAgent agent;
    public List<Vector3> randomLocations;
    public int random;
    public bool move = true;
    public float haltTime;

    private void Start()
    {
        StartCoroutine("GenerateRandomNumber");
    }

    // Update is called once per frame
    void Update()
    {
        if (move) {
           agent.destination = randomLocations[random];
            move = false;
        }
        
    }

    IEnumerator GenerateRandomNumber() {
        while (true) {
            yield return new WaitForSeconds(haltTime);
            random = Random.Range(0, randomLocations.Count);
            move = true;
        }
    }

    
}
