using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RedLightGreenLight : MonoBehaviour
{

    public float Speed;
    Vector3 movement;

    public float minRedSpeed, maxRedSpeed, minGreenSpeed, maxGreenSpeed;
    public bool wonGame;
    public bool canMove;

    public Transform respawnPoint;

    bool reactionTimeActive;
    public float reactionTime = .2f;

    public MeshRenderer stopLight;
    public Color redColor, greenColor;

    // Start is called before the first frame update
    void Start()
    {
        wonGame = false;
        canMove = false;
        Debug.Log("okay lets go");
        reactionTimeActive = false;
        StartCoroutine(RLGL());
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove)
        {
            transform.position = transform.position + movement * Time.deltaTime * Speed;
        }
        else
        {
            if(movement.magnitude > 0f && !reactionTimeActive)
            {
                transform.position = respawnPoint.position;
            }
        }
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        Vector2 movementVector2 = context.ReadValue<Vector2>();
        movement = new Vector3(movementVector2.x, 0, movementVector2.y);
    }

    IEnumerator RLGL()
    {
        while(!wonGame)
        {
            if(canMove)
            {
                canMove = false;
                stopLight.sharedMaterial.color = redColor;
                StartCoroutine(ReactionTime());
                yield return new WaitForSeconds(Random.Range(minRedSpeed, maxRedSpeed));
            }
            else
            {
                canMove = true;
                stopLight.sharedMaterial.color = greenColor;
                yield return new WaitForSeconds(Random.Range(minGreenSpeed, maxGreenSpeed));
                
            }
        }
    }

    IEnumerator ReactionTime()
    {
        reactionTimeActive = true;
        yield return new WaitForSeconds(reactionTime);
        reactionTimeActive = false;
    }
}
