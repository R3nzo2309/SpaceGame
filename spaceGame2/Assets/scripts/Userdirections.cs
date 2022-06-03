using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Userdirections : MonoBehaviour
{
    float speed = 1.0f;
    float higher = 25.0f;
    float lower = -25.0f;
    float maxlow = -50.0f;
    float maxhigh = 50.0f;
    float secondlow = -51.0f;
    float secondhigh = 51.0f;
    
    
    void Start()
    {
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, 0, higher) * Time.deltaTime );
            if (transform.eulerAngles.z > maxhigh && transform.eulerAngles.z < secondhigh)
            {
                transform.eulerAngles = new Vector3(0, 0, 50);
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 0, lower) * Time.deltaTime);
            if (transform.eulerAngles.z < maxlow && transform.eulerAngles.z > secondlow)
            {
                transform.eulerAngles = new Vector3(0, 0, -50);
            }
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(speed, 0, 0) * Time.deltaTime);
        }
    }

}
