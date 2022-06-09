using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCameraPos : MonoBehaviour
{
    private SpriteRenderer player;
    private Camera cameraSize;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player").GetComponent<SpriteRenderer>();
        cameraSize = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.y > 5.0f)
        {
            transform.position = new Vector3(18.0f, 11.0f, -10.0f);
            cameraSize.orthographicSize = 8;
        }
        if (player.transform.position.y <= 4.5f)
        {
            transform.position = new Vector3(-5.0f, 0.0f, -10.0f);
            cameraSize.orthographicSize = 9;
        }
        if (player.transform.position.x < 2.0f && player.transform.position.y > 4.5f)
        {
            transform.position = new Vector3(-16.0f, 11.0f, -10.0f);
            cameraSize.orthographicSize = 8;
        }
        if (player.transform.position.x < 2.0f && player.transform.position.y > 15.0f)
        {
            transform.position = new Vector3(-15.0f, 20.0f, -10.0f);
        }
        if (player.transform.position.y > 25.0f)
        {
            transform.position = new Vector3(-35.5f, 30.0f, -10.0f);
        }
    }
}
