using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    public bool climbing = false;
    public string ladder;
    private float cs = 10.0f;
    private float speed = 4.0f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(ladder))
        {
            climbing = true;
            rb.gravityScale = 0.0f;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(ladder))
        {
            climbing = false;
            rb.gravityScale = 0.3f;
        }
    }

    void Update()
    {
        if (climbing == true)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(new Vector3(0.0f, cs, 0) * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(new Vector3(0, -speed, 0) * Time.deltaTime);
            }
        }
    }
}
