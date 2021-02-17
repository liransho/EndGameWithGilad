using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{

    public Transform FirePoint;
    public GameObject bulletPrefab;
    public Transform player;
    private float timer ;
    private float timeBetweenAtack = 0.5f;
    public float distanceBetweenTanks ;
   

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Tank").transform;
    }
    void Update()
    {
        timer += Time.deltaTime;
        if (Vector2.Distance(transform.position, player.position) < distanceBetweenTanks)
        {
            if (timer >= timeBetweenAtack)
            {
                shoot();
            }
        }

    }

    public void shoot()
    {
        timer = 0;
        Instantiate(bulletPrefab, FirePoint.position, FirePoint.rotation);
    }
}
