using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float min_X = -8f, max_X = 8f;

    public GameObject[] asteroid_Prefabs;
    public GameObject enemyPrefab;

    public float timer = 1f;

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemies();
    }

    void SpawnEnemies()
    {
        float pos_X = Random.Range(min_X, max_X);
        Vector3 temp = transform.position;
        temp.x = pos_X;

        if (Random.Range(0, 2) > 0)
        {
            Instantiate(asteroid_Prefabs[Random.Range(0, asteroid_Prefabs.Length)], temp, Quaternion.identity);
        }
        else
        {
            Instantiate(enemyPrefab, temp, Quaternion.Euler(0f, 0f, 180f));
        }

        Invoke("SpawnEnemies", timer);
    }

}//@BY RITHEESH
