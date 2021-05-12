using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpSuprise : MonoBehaviour
{
    [SerializeField] GameObject OpenChestUI;
    public PlayerMovement2D kill;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            ActivatePopUp();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            DeactivatePopUp();
        }
    }

    public void ActivatePopUp()
    {
        OpenChestUI.SetActive(true);
    }

    public void DeactivatePopUp()
    {
        OpenChestUI.SetActive(false);
    }

    public void KillPlayer()
    {
        if (kill != null)
            kill.ResetCharacter();     
    }
}
