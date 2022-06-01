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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<SpriteRenderer>().sprite = playerFront;
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(speed, 0, 0) * Time.deltaTime);
            GetComponent<SpriteRenderer>().sprite = playersRightSide;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-speed, 0, 0) * Time.deltaTime);
            GetComponent<SpriteRenderer>().sprite = playersLeftSide;
        }
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<SpriteRenderer>().sprite = playersBack;
        }
    }
}
