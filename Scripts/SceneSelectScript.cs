using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelectScript : MonoBehaviour
{
    public void selectScene()
    {
        switch (this.gameObject.name)
        {
            case "LEVEL 1":
                SceneManager.LoadScene("OWO");
                break;
            case "LEVEL 2":
                SceneManager.LoadScene("Level 2");
                break;
            case "ReturnButton":
                SceneManager.LoadScene("Main Menu");
                break;
            case "Respawn1":
                SceneManager.LoadScene("OWO");
                break;
            case "Respawn2":
                SceneManager.LoadScene("Level 2");
                break;
            case "Main menu":
                SceneManager.LoadScene("Main Menu");
                break;
            case "Levels":
                SceneManager.LoadScene("LevelSelectionMainMenu");
                break;
        }
    }
 }


