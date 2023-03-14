using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -17;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    public GameObject dogPrefab;
    public float SpawnRate = 1F;
    private float timestamp = 0F;

    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }
    void SpawnRandomBall()
    {
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= timestamp)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timestamp = Time.time + SpawnRate;
        }
    }


}
