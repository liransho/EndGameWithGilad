using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity = transform.up * speed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Arena")
        {
            Destroy(gameObject);
        }
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            Debug.Log("Enemy destroy");
        }
        if (collision.gameObject.tag == "Tank")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            
        }

    }


}
