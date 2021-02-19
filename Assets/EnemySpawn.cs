using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public int count = 0;
    public Transform[] spawnPoints;
    public Transform[] prizeSpawnPoints;
    public GameObject enemy;
    public GameObject freezePrize;
    public GameObject speedPrize;
    public GameObject slowPrize;
    public bool[] prizeAlreadyUsed;
    public bool[] enemyAlreadyUsed;
    public int enemyRandomIndex;
    public int prizeRandomIndex;
    public float targetTime = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        enemyAlreadyUsed = new bool[spawnPoints.Length];
        for (int i = 0; i < 4; i++)
        {
            enemyRandomIndex = Random.Range(0, enemyAlreadyUsed.Length);
            while (enemyAlreadyUsed[enemyRandomIndex] == true)
            {
                enemyRandomIndex = Random.Range(0, enemyAlreadyUsed.Length);
            }
            enemyAlreadyUsed[enemyRandomIndex] = true;
            Instantiate(enemy, spawnPoints[enemyRandomIndex].position, Quaternion.identity); 
        }
        prizeAlreadyUsed = new bool[prizeSpawnPoints.Length];
        for (int j=0; j < 4; j++)
        {
            prizeRandomIndex = Random.Range(0, prizeAlreadyUsed.Length);
            while (prizeAlreadyUsed[prizeRandomIndex] == true)
            {
                prizeRandomIndex = Random.Range(0, prizeAlreadyUsed.Length);
            }
            prizeAlreadyUsed[prizeRandomIndex] = true;
            count++;
            if (count == 1)
            {
                freezePrize = (GameObject)Instantiate(freezePrize, prizeSpawnPoints[prizeRandomIndex].position, Quaternion.identity);
            }
            else if (count == 2)
            {
                speedPrize = (GameObject)Instantiate(speedPrize, prizeSpawnPoints[prizeRandomIndex].position, Quaternion.identity);
            }
            else if (count == 3)
            {
                slowPrize = (GameObject)Instantiate(slowPrize, prizeSpawnPoints[prizeRandomIndex].position, Quaternion.identity);
            }


        }
    }

    void Update()
    {
        targetTime -= Time.deltaTime;

        if (targetTime <= 0)
        {
            Destroy(freezePrize,0.01f);
            Destroy(speedPrize,0.01f);
            Destroy(slowPrize,0.01f);
            targetTime = 10f;
            count = 0;
           
            for (int i=0; i< prizeAlreadyUsed.Length; i++)
             {
                 prizeAlreadyUsed[i] = false;
             }
             for (int j = 0; j < prizeAlreadyUsed.Length; j++)
             {
                 prizeRandomIndex = Random.Range(0, prizeAlreadyUsed.Length);
                 while (prizeAlreadyUsed[prizeRandomIndex] == true)
                 {
                     prizeRandomIndex = Random.Range(0, prizeAlreadyUsed.Length);
                 }
                 prizeAlreadyUsed[prizeRandomIndex] = true;
                 count++;
                 if (count == 1)
                 {
                     freezePrize = (GameObject)Instantiate(freezePrize, prizeSpawnPoints[prizeRandomIndex].position, Quaternion.identity);
                 }
                 else if (count == 2)
                 {
                     speedPrize = (GameObject)Instantiate(speedPrize, prizeSpawnPoints[prizeRandomIndex].position, Quaternion.identity);
                 }
                 else if (count == 3)
                 {
                     slowPrize = (GameObject)Instantiate(slowPrize, prizeSpawnPoints[prizeRandomIndex].position, Quaternion.identity);
                 }
             }

        }

    }


}
