using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] robotPrefabs;
    private float spawnRangeX = -5;
    private float spawnPosZ = -25;
    private float startDelay = 2;
    private float spawnInterval = 4f;
    public float sideSpawnMinZ;
    public float sideSpawnMaxZ;
    public float sideSpawnX;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomRobot", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomRobot()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int robotIndex = Random.Range(0, robotPrefabs.Length);
        Instantiate(robotPrefabs[robotIndex], spawnPos, robotPrefabs[robotIndex].transform.rotation);
    }
}
