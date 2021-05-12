using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathManager : MonoBehaviour
{
    DeathManager instance;
    public int deaths = 0;
    public Text deathText;

    private void Awake()
    {
        DontDestroyOnLoad(this);

        if (FindObjectOfType<DeathManager>().GetHashCode() != this.GetHashCode())
        {
            Destroy(gameObject);
        }
        UpdateText();
    }

    public void IncreaseDeaths()
    {
        instance = this;
        deaths += 1;
        deathText.text = "Deaths " + deaths;
        //DontDestroyOnLoad(instance);
    }

    void UpdateText() {
        deathText.text = "Deaths " + deaths;
    }
}
