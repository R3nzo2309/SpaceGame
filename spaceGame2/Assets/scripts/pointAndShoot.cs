using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointAndShoot : MonoBehaviour
{
    private Vector3 target;
    public GameObject turret;
    public GameObject crosshairs;
    public GameObject bulletPrefab;
    public GameObject prefabClone;
    public float bulletSpeed = 60.0f;
    public GameObject bulletstart;

    float timer = 0.0f;
    float cooldownTime = 0.8f;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        target = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
        crosshairs.transform.position = new Vector2(target.x, target.y); // makes the crosshair follow the cursor 

        Vector3 difference = target - turret.transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        turret.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);

        if (timer > cooldownTime)
        {
            if (Input.GetMouseButtonDown(0))
            {
                float distance = difference.magnitude;
                Vector2 direction = difference / distance;
                direction.Normalize();
                fireBullet(direction, rotationZ);
                var startPosition = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z)); // gets the location where you click your mouse
                Debug.Log(startPosition); // writes location of mouseclick in debug.log
                timer = 0; // reset timer
            }
        }
        if (timer < cooldownTime + 1)
        {
            timer += Time.deltaTime;
        }
    }


    void fireBullet(Vector2 direction, float rotationZ)
    {
        prefabClone = Instantiate(bulletPrefab) as GameObject;
        prefabClone.transform.position = bulletstart.transform.position; // bullet starts here
        prefabClone.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ); // bullet goes in direction of the mouse
        prefabClone.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
        Destroy(prefabClone, 1);
        //while (prefabClone.transform.position < startPosition)
        //{
        //    Destroy(prefabClone);
        //}
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject)
        {
            Destroy(gameObject);
            Destroy(col.gameObject);
        }
    }
}
