using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerWinScript : MonoBehaviour
{

    public RedLightGreenLight rlgl;

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Level 1 completed!");     
            // rlgl.wonGame = true;

        }
    }
    
}
