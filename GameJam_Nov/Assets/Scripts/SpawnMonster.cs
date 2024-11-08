using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMonster : MonoBehaviour
{
    
    public float spawnDelayMin;
    public float spawnDelayMax;

    public float maxSpawnDistance;

    public float minSpawnDistance;

    float timer = 0;
    float Delay;

    public GameObject monsterPrefab;

    

    // Start is called before the first frame update
    void Start()
    {
        Delay = UnityEngine.Random.Range(spawnDelayMin, spawnDelayMax + 1);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > Delay)
        {
            Spawn();
            timer = 0;
            Delay = UnityEngine.Random.Range(spawnDelayMin, spawnDelayMax + 1);
        }
    }

    private void Spawn()
    {
        float randomX = gameObject.transform.position.x + UnityEngine.Random.Range(-maxSpawnDistance, maxSpawnDistance);
        float randomY = gameObject.transform.position.y + UnityEngine.Random.Range(-maxSpawnDistance, maxSpawnDistance);

        Vector3 RandomPoint = new Vector3(randomX, randomY);

        Instantiate(monsterPrefab, RandomPoint, Quaternion.identity);
        print("Monster spawned");
    }
}
