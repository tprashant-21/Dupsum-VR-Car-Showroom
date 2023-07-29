using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube2Event : MonoBehaviour
{
    public evenetManager evMan;
    // Start is called before the first frame update
    void Start()
    {
        evMan.SpacebarPress += MoveRight;
    }

    void MoveRight(float receivedFloat)
    {
        transform.position += new Vector3(receivedFloat, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
