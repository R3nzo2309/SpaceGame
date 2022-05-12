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

    private Vector3 startPosition;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        target = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
        crosshairs.transform.position = new Vector2(target.x, target.y);

        Vector3 difference = target - turret.transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        turret.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);

        if (Input.GetMouseButtonDown(0))
        {
            float distance = difference.magnitude;
            Vector2 direction = difference / distance;
            direction.Normalize();
            fireBullet(direction, rotationZ);
            startPosition = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
            Debug.Log(startPosition);
        }
    }

    
void fireBullet(Vector2 direction, float rotationZ)
    {
        prefabClone = Instantiate(bulletPrefab) as GameObject;
        prefabClone.transform.position = bulletstart.transform.position; // bullet starts here
        prefabClone.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ); // bullet goes in direction of the mouse
        prefabClone.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;

        while (prefabClone.transform.position < startPosition)
        {
            Destroy(prefabClone);
        }
    }
}


