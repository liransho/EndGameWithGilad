using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject enemy;
    public bool[] alreadyUsed;
    public int randomIndex;
    // Start is called before the first frame update
    void Start()
    {
        alreadyUsed = new bool[spawnPoints.Length];
        for (int i = 0; i < 4; i++)
        {
            randomIndex = Random.Range(0, alreadyUsed.Length);
            while (alreadyUsed[randomIndex] == true)
            {
                randomIndex = Random.Range(0, alreadyUsed.Length);
            }
            alreadyUsed[randomIndex] = true;
            Instantiate(enemy, spawnPoints[randomIndex].position, Quaternion.identity);
        }
    }

}
