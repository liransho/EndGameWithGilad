using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    public float RotateSpeed = 100f;
    public Track trackLeft;
    public Track trackRight;
    public float moveSpeed = 100f;
    bool moveForward = false;
    bool moveReverse = false;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.forward * -RotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * RotateSpeed * Time.deltaTime);
        }
        moveReverse = (Input.GetKeyDown(KeyCode.S)) ? true : moveReverse;
        moveReverse = (Input.GetKeyUp(KeyCode.S)) ? false : moveReverse;
        moveForward = (Input.GetKeyDown(KeyCode.W)) ? true : moveForward;
        moveForward = (Input.GetKeyUp(KeyCode.W)) ? false : moveForward;
        if (moveForward | moveReverse)
        {
            trackStart();
        }
        else
        {
            trackStop();
        }

        void trackStart()
        {
            trackLeft.animator.SetBool("IsMove", true);
            trackRight.animator.SetBool("IsMove", true);
        }

        void trackStop()
        {
            trackLeft.animator.SetBool("IsMove", false);
            trackRight.animator.SetBool("IsMove", false);
        }
    }

}
