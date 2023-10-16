using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Spawn random ball at a random x position at the top of the play area
    void SpawnRandomBall()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // Instantiate a ball at a random spawn location
        int ballNumber = Random.Range(0,2); // Corrected variable name and used ballPrefabs.Length
        Instantiate(ballPrefabs[ballNumber], spawnPos, ballPrefabs[ballNumber].transform.rotation);
        Invoke("SpawnRandomBall",Random.Range(2f,4f));
    }
}
