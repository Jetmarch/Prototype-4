using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject powerupPrefub;
    public int enemyCount;
    public int waveNumber = 1;

    private float spawnRange = 9.0f;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(waveNumber);
        SpawnPrefabAtRandomPosition(powerupPrefub);
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;

        if(enemyCount == 0)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
            SpawnPrefabAtRandomPosition(powerupPrefub);
        }
    }

    private void SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            SpawnPrefabAtRandomPosition(enemyPrefab);
        }
    }

    private void SpawnPrefabAtRandomPosition(GameObject prefab)
    {
        Instantiate(prefab, GenerateRandomPosition(), prefab.transform.rotation);
    }

    private Vector3 GenerateRandomPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);

        return new Vector3(spawnPosX, 0, spawnPosZ);
    }
}
