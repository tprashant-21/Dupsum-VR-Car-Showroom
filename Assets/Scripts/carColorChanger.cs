using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carColorChanger : MonoBehaviour
{

    public MeshRenderer[] renderers;

    public void ChangeColorOnRenderers(carColorHolder color)
    {
        foreach(MeshRenderer rend in renderers)
        {
            rend.material.color = color.passedColor;
        }
    }

}
