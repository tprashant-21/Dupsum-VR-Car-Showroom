using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firingPad : MonoBehaviour
{

    public GameObject bulletPrefabs;
    public Transform spwanPoint;
    public float bulletForce;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            // Debug.Log("You hit the firing pad");
            GameObject spwanedBullet = Instantiate(bulletPrefabs, spwanPoint.position, spwanPoint.rotation);
            spwanedBullet.GetComponent<Rigidbody>().AddForce(spwanedBullet.transform.forward * bulletForce, ForceMode.VelocityChange);
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
