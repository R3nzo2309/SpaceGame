using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class valuabletesting : MonoBehaviour
{
    
    void Start()
    {
        int speed = 10;
        int higher = 5;
        int lower = -5;

        Vector3 userdirection = Vector3.right;

    }
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector2());
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector2());
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(userdirection * speed * Time.deltaTime);
        }
    }

}
