using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public float speed = 5f; 

    private Rigidbody2D rb;
    public Transform ball;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {

        Vector3 ballPosition = ball.transform.position;


        if (ballPosition.y > rb.position.y)
        {
            rb.velocity = new Vector2(0, speed);
        }
        else if (ballPosition.y < rb.position.y)
        {
            rb.velocity = new Vector2(0, -speed);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}