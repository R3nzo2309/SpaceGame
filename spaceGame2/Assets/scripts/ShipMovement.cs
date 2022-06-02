using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ShipMovement : MonoBehaviour
{
    private float speed = 3.0f;
    private float higher = 100.0f;
    private float lower = -100.0f;
    private float maxlow = -70.0f;
    private float maxhigh = 50.0f;
    private float secondlow = -71.0f;
    private float secondhigh = 51.0f;


    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, 0, higher) * Time.deltaTime);
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
                transform.eulerAngles = new Vector3(0, 0, -70);
            }
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(speed, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(-speed, 0, 0) * Time.deltaTime);
        }
    }

}
