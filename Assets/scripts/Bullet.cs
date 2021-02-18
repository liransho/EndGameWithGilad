using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject exp;
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
            exp = (GameObject) Instantiate(exp, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(exp, 0.2f);

        }
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            exp = (GameObject)Instantiate(exp, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject);
            Destroy(exp,0.2f);
        }
        if (collision.gameObject.tag == "Tank")
        {
            Destroy(collision.gameObject);
            exp = (GameObject)Instantiate(exp, transform.position, transform.rotation);
            Destroy(gameObject);
            Destroy(exp,0.2f);
        }

    }


}
