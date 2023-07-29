using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarRotator : MonoBehaviour
{
    public void UpdateCarRotation(float sliderValue)
    {
        Vector3 newRotation = new Vector3(transform.rotation.x, sliderValue, transform.rotation.z);
        transform.rotation = Quaternion.Euler(newRotation);
    }
}
