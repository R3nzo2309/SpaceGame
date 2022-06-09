using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private float speed = 4.0f;
    private bool showBack = false;

    public Sprite playersBack;
    public Sprite playersRightSide;
    public Sprite playersLeftSide;
    public Sprite playerFront;

    public Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;

    private bool jump = false;




    
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        spriteRenderer.sprite = playerFront;

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(speed, 0, 0) * Time.deltaTime);
            spriteRenderer.sprite = playersRightSide;
            showBack = false;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-speed, 0, 0) * Time.deltaTime);
            spriteRenderer.sprite = playersLeftSide;
            showBack = false;
        }
        if (Input.GetKey(KeyCode.W))
        {
            spriteRenderer.sprite = playersBack;
            showBack = true;
        }
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W))
        {
            spriteRenderer.sprite = playersRightSide;
            showBack = false;
        }
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
        {
            spriteRenderer.sprite = playersLeftSide;
            showBack = false;
        }
        if (jump == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {

                rb.AddForce(new Vector2(0, 2), ForceMode2D.Impulse);
            }
        }
        if (showBack == true)
        {
            spriteRenderer.sprite = playersBack;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject)
        {
            jump = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject)
        {
            jump = false;
        }
    }
}
