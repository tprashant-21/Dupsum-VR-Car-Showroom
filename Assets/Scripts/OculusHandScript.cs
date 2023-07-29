using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class OculusHandScript : MonoBehaviour
{
    Animator anim;

    public InputActionReference gripReference;
    public InputActionReference triggerReference;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        gripReference.action.started += GripStarted;
        gripReference.action.canceled += GripCancelled;
        triggerReference.action.started += TriggerStarted;
        triggerReference.action.canceled += TriggerCancelled;
    }

    private void OnDestroy() 
    {
        gripReference.action.started -= GripStarted;
        gripReference.action.canceled -= GripCancelled;
        triggerReference.action.started -= TriggerStarted;
        triggerReference.action.canceled -= TriggerCancelled;
        
    }

    void GripStarted(InputAction.CallbackContext context)
    {
        anim.SetBool("GripPressed", true);
    }

    void GripCancelled(InputAction.CallbackContext context)
    {
        anim.SetBool("GripPressed", false);
    }

    void TriggerStarted(InputAction.CallbackContext context)
    {
        anim.SetBool("TriggerPressed", true);
    }

    void TriggerCancelled(InputAction.CallbackContext context)
    {
        anim.SetBool("TriggerPressed", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
