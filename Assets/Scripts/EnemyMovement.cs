using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Collider2D enemyCollider;
    public float movementSpeed;
    private bool newDirection = true;

    void Start()
    {
        enemyCollider = GetComponent<Collider2D>();
    }
    void Update()
    {
        transform.position = new Vector3(transform.position.x + movementSpeed * Time.deltaTime, transform.position.y, transform.position.z);
        if (enemyCollider.IsTouchingLayers(LayerMask.GetMask("Labyrinth")) && newDirection)
        {
            Debug.Log("Touch");
            newDirection = false;
        }
        else
        {
            Debug.Log("No touch");
            newDirection = true;
        }
    }
}
