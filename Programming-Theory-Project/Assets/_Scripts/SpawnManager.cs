using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] spherePrefabs;
    [SerializeField]private float spawnRangeX = 10;
    [SerializeField]private float spawnPosY = 20;
    [SerializeField] private float startDelay = 3.0f;
    [SerializeField] private float spawnInterval = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomSphere", startDelay, spawnInterval);
    }

    void SpawnRandomSphere()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnPosY, 0);
        int sphereIndex = Random.Range(0, spherePrefabs.Length);
        Instantiate(spherePrefabs[sphereIndex], spawnPos,
                        spherePrefabs[sphereIndex].transform.rotation);
    }
}
