using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 50f;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(moveH * speed, moveV * speed);
        if (moveH != 0)
        {
            transform.localScale = new Vector3(Mathf.Sign(moveH), 1, 1);
        }
    }
}
