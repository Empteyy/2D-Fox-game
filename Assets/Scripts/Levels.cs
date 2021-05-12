using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    public void selectScene()
    {
        switch (this.gameObject.name)
        {
            case "Levels":
                SceneManager.LoadScene("LevelSelectionMainMenu");
                break;
        }
    }
}