using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCameraPos : MonoBehaviour
{
    private SpriteRenderer player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player").GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.y > 5.0f)
        {
            transform.position = new Vector3(0.0f, 10.0f, -10.0f);
        }
        if (player.transform.position.y <= 4.5f)
        {
            transform.position = new Vector3(0.0f, 0.0f, -10.0f);
        }
    }
}
