using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    public Transform player;  // 主角的Transform
    public float followSpeed = 50f;  // NPC 跟随的速度
    public float stoppingDistance = 10f;  // 跟随的最小距离

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float distance = Vector2.Distance(transform.position, player.position);

        if (distance > stoppingDistance)
        {
            Vector2 direction = (player.transform.position - transform.position).normalized;  // 得到前进方向
            Vector2 newPosition = (Vector2)transform.position + direction * followSpeed * Time.fixedDeltaTime;
            rb.MovePosition(newPosition);
        }

        if (player.position.x > transform.position.x)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (player.position.x < transform.position.x)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }

}
