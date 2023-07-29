using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemyPrefabs;
    public Transform[] enemySpawnPoints;
    public float enemyForce;

    public float timeBetweenSpawns;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0f;   
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timeBetweenSpawns < timer)
        {
            timer = 0f;
            Transform chosenTransform = enemySpawnPoints[Random.Range(0, enemySpawnPoints.Length)];
            GameObject spawnedEnemy = Instantiate(enemyPrefabs, chosenTransform.position, chosenTransform.rotation);
            spawnedEnemy.GetComponent<Rigidbody>().AddForce(spawnedEnemy.transform.forward * enemyForce, ForceMode.VelocityChange);

        }
    }
}
