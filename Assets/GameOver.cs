using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] GameObject deathUI;
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateGameover()
    {
        Time.timeScale = 0;
        AudioListener.pause = true;
        
    }

    void DeactivateGameover()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
        deathUI.SetActive(false);
       
    }
}
