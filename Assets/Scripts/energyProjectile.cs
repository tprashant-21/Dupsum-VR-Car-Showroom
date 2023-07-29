using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class energyProjectile : MonoBehaviour
{
    public GameObject hitParticlePrefab;
    public float maxlifetime;

    public float timer;

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            Instantiate(hitParticlePrefab, transform.position, transform.rotation);
            scoreManager.Instance.AddtoScore();
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > maxlifetime)
        {
            Destroy(gameObject);
        }
    }
}
