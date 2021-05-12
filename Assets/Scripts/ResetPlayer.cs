using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayer : MonoBehaviour
{
    PlayerMovement2D reset;

    public void KillButton()
    {
        reset.ResetCharacter();
    }
}
