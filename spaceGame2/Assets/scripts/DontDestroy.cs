using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
    private void Awake()
    {
        GameObject[] soundObj = GameObject.FindGameObjectsWithTag("GameMusic");

        if(soundObj.Length > 1 || SceneManager.GetActiveScene().buildIndex == 3 || SceneManager.GetActiveScene().buildIndex == 0)
        {
            gameObject.SetActive(false);
        }
        

        if (SceneManager.GetActiveScene().buildIndex == 1 || SceneManager.GetActiveScene().buildIndex == 2)
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
