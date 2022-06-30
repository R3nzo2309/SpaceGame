using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 10f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-speed, 0, 0) * Time.deltaTime);
    }
}
