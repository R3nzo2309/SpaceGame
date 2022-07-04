using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour
{
    public static float timer = 0;
    public static float win = 180f;
    public static bool timerOn = true;
    public AudioSource click;
    private GameObject backgroundMusic;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        backgroundMusic = GameObject.FindGameObjectWithTag("GameMusic");
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
                backgroundMusic.SetActive(false);
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
        timerOn = true;
        SceneManager.LoadScene("main-game-scene");
        Time.timeScale = 1f;
        AudioListener.pause = false;
        UI.health = 0;
        timer = 0f;
        win = 180f;
        DamageOverTime.timerCount = 0;
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
