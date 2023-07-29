using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerPlane : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("The enemy approached your base. You lose!");
            scoreManager.Instance.currentScore = 0;
        }    
    }
}
