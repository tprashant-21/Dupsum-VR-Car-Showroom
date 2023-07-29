using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeManagerScript : MonoBehaviour
{
    public static cubeManagerScript Instance;
    public int currentScore;
    public int winScore;

    private void Awake() 
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    
    // Start is called before the first frame update
    void Start()
    {
        currentScore = 0;
        
    }

    public void AddToScore()
    {
        currentScore++;
        if(currentScore == winScore)
        {
            Debug.Log("You Win!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
