using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;

    private float spawnRange = 9.0f;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyAtRandomPosition();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    private void SpawnEnemyAtRandomPosition()
    {
        Instantiate(enemyPrefab, GenerateRandomPosition(), enemyPrefab.transform.rotation);
    }

    private Vector3 GenerateRandomPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);

        return new Vector3(spawnPosX, 0, spawnPosZ);
    }
}
