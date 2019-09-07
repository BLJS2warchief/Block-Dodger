using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 15f;
    public float mapWidth = 6f;
    public float speedCoefficient = 1f;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {

        if(Input.GetKey(KeyCode.Q))
        {
            rb.position = new Vector2(-6, rb.position.y);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            rb.position = new Vector2(-3, rb.position.y);
        }
        else if (Input.GetKey(KeyCode.E))
        {
            rb.position = new Vector2(0, rb.position.y);
        }
        else if (Input.GetKey(KeyCode.R))
        {
            rb.position = new Vector2(3, rb.position.y);
        }
        else if (Input.GetKey(KeyCode.T))
        {
            rb.position = new Vector2(6, rb.position.y);
        }

        float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;

        Vector2 newPosition = rb.position + Vector2.right * x;

        newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);

        rb.MovePosition(newPosition);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<GameManager>().EndGame();
    }
}
