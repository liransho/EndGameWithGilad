using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float laserLength = 50f;
    RaycastHit2D hit;
    public Transform target;
    Vector2 targerPosition;
    public Transform firePoint;

    private void Start()
    {
        target = GameObject.Find("Tank").transform;
        firePoint = GameObject.Find("FirePoint").transform;   
    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        targerPosition = target.position;
        hit = Physics2D.Raycast(firePoint.position, targerPosition, laserLength);
        if (hit.collider != null)
        {
            //Hit something, print the tag of the object
            Debug.Log("Hitting: " + hit.collider.tag);
        }
        Debug.DrawRay(transform.position, targerPosition * laserLength, Color.red);
    }
}
