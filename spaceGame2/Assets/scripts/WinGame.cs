using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour
{
    public float timer = 0;
    private float win = 120f;
    public static bool timerOn = true;
    public AudioSource click;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (timerOn == true)
        {
            if (timer <= win)
            {
                timer += 1 * Time.deltaTime;
            }

            if (timer >= win)
            {
                timer = 0;
                timerOn = false;
                WinGameScreen();
            }
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
        timerOn = true;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("main-menu");
    }

    public void Clicked()
    {
        click.Play();
    }
}
