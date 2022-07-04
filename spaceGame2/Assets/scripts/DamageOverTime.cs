using UnityEngine;
using UnityEngine.UI;

public class DamageOverTime : MonoBehaviour
{
    private float safeTime = 40;
    private float almostTime = 0f;
    public GameObject LoseMenu;

    public static bool gameIsPaused = false;
    public bool timerOn = true;
    public static float timerCount = 0;

    public AudioSource endmusic;

    public Text timeRemaining;
    void Update()
    {

        timeRemaining.text = safeTime.ToString("incoming in: 0.0 sec");

        if (timerOn == true)
        {
            if(timerCount == 0)
            {
                if (almostTime <= safeTime)
                {
                    safeTime -= 1 * Time.deltaTime;
                }

                if (almostTime >= safeTime)
                {
                    safeTime = 10;
                    UI.health += 1;
                    timerCount += 1;
                }
            }

            else if(timerCount == 1)
            {
                if (almostTime <= safeTime)
                {
                    safeTime -= 1 * Time.deltaTime;
                }

                if (almostTime >= safeTime)
                {
                    safeTime = 5;
                    UI.health += 1;
                    timerCount = 0;
                    Debug.Log("reset timercount");
                }
            }

            if (UI.health == 3)
            {
                EndGame();
                safeTime = 0;
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
