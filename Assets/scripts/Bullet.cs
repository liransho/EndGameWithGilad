using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    public GameObject exp;
    public float speed = 20f;
    public Rigidbody2D rb;
    static int counter = 0;
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
            counter++;
            if(counter == 4)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }

          
        }
        if (collision.gameObject.tag == "Tank")
        {
            Destroy(collision.gameObject);
            exp = (GameObject)Instantiate(exp, transform.position, transform.rotation);
            Destroy(gameObject);
            Destroy(exp,0.2f);
            counter = 0;
            SceneManager.LoadScene(3);
        }

    }

   


}
