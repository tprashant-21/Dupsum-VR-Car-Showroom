using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerWinScriptLast : MonoBehaviour
{
    public RedLightGreenLight rlgl;

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("You won the game!");     
            rlgl.wonGame = true;

        }
    }
}
