using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ShipMovement : MonoBehaviour
{
    private float speed = 2.0f;
    private float sideways = 4.0f;

    public Animator fire;


    void Update()
    {
        transform.position += new Vector3(-1, 0.0f, 0.0f) * Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0.0f, speed, 0.0f) * Time.deltaTime;
            transform.rotation = Quaternion.Euler(Vector3.forward * 15);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            transform.rotation = Quaternion.Euler(Vector3.forward * 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0.0f, -speed, 0.0f) * Time.deltaTime;
            transform.rotation = Quaternion.Euler(Vector3.forward * -15);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            transform.rotation = Quaternion.Euler(Vector3.forward * 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-sideways, 0.0f, 0.0f) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(sideways, 0.0f, 0.0f) * Time.deltaTime;
            fire.SetTrigger("SlowDown");
        }
    }

}
