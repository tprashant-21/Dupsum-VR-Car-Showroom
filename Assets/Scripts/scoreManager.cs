using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreManager : MonoBehaviour
{

    public static scoreManager Instance;

    public int currentScore;

    private void Awake() {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public void AddtoScore()
    {
        currentScore++;
        Debug.Log("The Current Score is:" + currentScore);
    }
    // Start is called before the first frame update
    void Start()
    {
        currentScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
