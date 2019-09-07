using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;

    public GameObject blockPrefab;

    public float timeBetweenWaves = 1f;
    private float timeToSpawn = 2f;

    // Start is called before the first frame update
    void Update()
    {
        if(Time.time >= timeToSpawn)
        {
            SpawnBlocks();
            timeToSpawn = Time.time + timeBetweenWaves;
        }
    }

    void SpawnBlocks()
    {
        int RandomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (RandomIndex != i)
            {
                Instantiate(blockPrefab, spawnPoints[i]);
            }
        }
    }

}
