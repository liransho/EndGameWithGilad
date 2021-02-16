using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{

    public Transform FirePoint;
    public GameObject bulletPrefab;

    private float timer ;
    private float timeBetweenAtack = 1f;
   
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= timeBetweenAtack)
        {
            shoot();
        }
    }

    void shoot()
    {
        timer = 0;
        Instantiate(bulletPrefab, FirePoint.position, FirePoint.rotation);
    }
}
