using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    public int playerHealth = 3;
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);

        GameObject[] gos = GameObject.FindGameObjectsWithTag("PlayerInfo");
        if(gos.Length > 1)
        {
            Destroy(gos[1]);
        }
    }
}
