using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    float speed = 4.0f;

    public Sprite playersBack;
    public Sprite playersRightSide;
    public Sprite playersLeftSide;
    public Sprite playerFront;

    public Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        spriteRenderer.sprite = playerFront;

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(speed, 0, 0) * Time.deltaTime);
            spriteRenderer.sprite = playersRightSide;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-speed, 0, 0) * Time.deltaTime);
            spriteRenderer.sprite = playersLeftSide;
        }
        if (Input.GetKey(KeyCode.W))
        {
            spriteRenderer.sprite = playersBack;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {

            rb.AddForce(new Vector2(0, 2), ForceMode2D.Impulse);
        }
    }
}
