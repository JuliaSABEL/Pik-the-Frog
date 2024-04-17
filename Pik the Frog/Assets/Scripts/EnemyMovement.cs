using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 3f;
    public LayerMask labyrinthLayer;

    private Rigidbody2D rb;
    private bool moveRight = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (moveRight)
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (labyrinthLayer == (labyrinthLayer | (1 << collision.gameObject.layer)))
        {
            moveRight = !moveRight;
        }
    }
}
