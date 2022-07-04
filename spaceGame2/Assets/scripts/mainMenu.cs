using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject settingMenuUI;

    public Animator transition;

    public AudioSource click;

    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        AudioListener.pause = false;
        gameIsPaused = false;
    }
    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        AudioListener.pause = true;
        gameIsPaused = true;
    }

    public void PlayGame()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        UI.health = 0;
        WinGame.timerOn = true;
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("main-menu");
        Time.timeScale = 1f;
        gameIsPaused = false;
        AudioListener.pause = false;
    }

    public void Retry()
    {
        SceneManager.LoadScene("main-game-scene");
        Time.timeScale = 1f;
        gameIsPaused = false;
        AudioListener.pause = false;
        UI.health = 0;
        WinGame.timer = 0f;
        WinGame.timerOn = true;
        WinGame.win = 180f;
        DamageOverTime.timerCount = 0;
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("start");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(levelIndex);
    }
    public void EndGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }


    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void Clicked()
    {
        click.Play();
    }
    
}
