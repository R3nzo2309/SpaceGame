using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageOverTime : MonoBehaviour
{
    private float timer = 0;
    private float time = 5f;
    private float timerCount = 0;
    public GameObject LoseMenu;

    public static bool gameIsPaused = false;
    public bool timerOn = true;

    public AudioSource endmusic;

    public Text timeRemaining;

    void Update()
    {
        if(timerOn == true)
        {
            if (timer <= time)
            {
                timer += 1 * Time.deltaTime;
            }

            if (timer >= time)
            {
                timer = 0;
                UI.health += 1;
                timerCount += 1;
            }

            if (timerCount == 3)
            {
                EndGame();
                timer = 0;
                timerCount = 0;
                timerOn = false;
            }
        }
        
    }

    public void EndGame()
    {
        LoseMenu.SetActive(true);
        Time.timeScale = 0f;
        AudioListener.pause = true;
        gameIsPaused = true;
        Cursor.visible = true;
        endmusic.Play();
    }
}
