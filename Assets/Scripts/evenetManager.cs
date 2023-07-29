using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class evenetManager : MonoBehaviour
{
    public event System.Action<float> SpacebarPress;
    public float passedFloat;

    public void ButtonPress(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            SpacebarPress?.Invoke(passedFloat);
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
