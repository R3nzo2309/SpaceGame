using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class insidetooutside : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        if (SceneManager.GetActiveScene().isLoaded)
        {
            if (Input.GetKey(KeyCode.G))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                DamageOverTime.timerCount = 0;
            }
            else if (Input.GetKey(KeyCode.G))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            }
        }
    }
}
