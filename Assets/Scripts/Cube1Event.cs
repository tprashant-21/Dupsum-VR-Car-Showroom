using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube1Event : MonoBehaviour
{

    public evenetManager evMan;
    // Start is called before the first frame update
    void Start()
    {
        evMan.SpacebarPress += MoveUp;
    }

    void MoveUp(float receivedFloat)
    {
        transform.position += new Vector3(0f, receivedFloat, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
