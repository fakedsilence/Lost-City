using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 50f;

    private Rigidbody2D rigidbody2D;

    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");
        rigidbody2D.velocity = new Vector2(moveH * speed, moveV * speed);
        if (moveH != 0)
        {
            transform.localScale = new Vector3(Mathf.Sign(moveH), 1, 1);
        }
    }
}
