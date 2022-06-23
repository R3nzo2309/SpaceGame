using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour
{

    private float timer = 0;
    private float win = 50f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if (timer <= win)
            {
                timer += 1 * Time.deltaTime;
            }

            if (timer >= win)
            {
            WinGameScreen();
            }
    }

    public void WinGameScreen()
    {
        SceneManager.LoadScene("WinScene");
        Cursor.visible = true;
    }

    public void Retry()
    {
        SceneManager.LoadScene("main-game-scene");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("main-menu");
    }
}
