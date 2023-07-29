using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateSunSkyBox : MonoBehaviour    
{

    private Light directionalLight;
    public Gradient timeofTheDay;
    public AnimationCurve intensityGraph;

    public void RotateSun(Slider passedSlider)
    {
        Quaternion newRot = Quaternion.Euler(passedSlider.value, transform.rotation.y, transform.rotation.z);
        transform.rotation = newRot;

        float betweenZeroAndOne = (passedSlider.value - passedSlider.minValue)/(passedSlider.maxValue - passedSlider.minValue);
        directionalLight.color = timeofTheDay.Evaluate(betweenZeroAndOne);
        directionalLight.intensity = intensityGraph.Evaluate(betweenZeroAndOne);
    }

    private void Start()
    {
        directionalLight = GetComponent<Light>();
    }
}
