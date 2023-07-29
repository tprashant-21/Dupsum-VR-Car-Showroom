using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerMovement : MonoBehaviour
{

    public float Speed;
    Vector3 movementVector;

    public void onMovement(InputAction.CallbackContext context)
    {
        Vector2 movement = context.ReadValue<Vector2>();
        movementVector = new Vector3(movement.x, 0f, movement.y);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + movementVector * Time.deltaTime * Speed;
    }
}
