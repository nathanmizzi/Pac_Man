using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] public GameObject[] ghost;
    [SerializeField] int maximumNumberOfEnemies = 3;
    [SerializeField] float spawnTime = 1f;
    [SerializeField] GameObject firstSpawnPoint;

    int currentNumberOfEnemies = 0;

    // Start is called before the first frame update
    void Start()
    {
      StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        while (currentNumberOfEnemies < maximumNumberOfEnemies)
        {
            GameObject enemyClone = Instantiate(ghost[currentNumberOfEnemies], firstSpawnPoint.transform.position,
                Quaternion.identity);

            currentNumberOfEnemies++;

            yield return new WaitForSeconds(spawnTime);
        }

        }
    }
