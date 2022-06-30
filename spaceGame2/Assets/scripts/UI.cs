using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    [SerializeField] private Sprite Full;
    [SerializeField] private Sprite TwoLives;
    [SerializeField] private Sprite OneLives;
    [SerializeField] private Sprite Empty;

    public static int health;
    public float healthBar;

    public static bool gameIsPaused = false;
    [SerializeField] private GameObject LoseMenu;

    private Image image;
    private ScreenShake shake;

    public AudioSource shipDamage;
    public AudioSource endmusic;

    private void Start()
    {
        image = GameObject.Find("/Canvas/player-info/health").GetComponent<Image>();
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<ScreenShake>();
        UpdateHealthUI();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject)
        {
            shake.CamShake();
            shipDamage.Play();
            TakeDamage();
            UpdateHealthUI();

            Destroy(collision.gameObject);

        }
    }
    private void UpdateHealthUI()
    {
        if (health == 0)
        {
            image.sprite = Full;
            healthBar = 0f;
        }
       else  if (health == 1)
        {
            image.sprite = TwoLives;
            healthBar = 1f;
        }

        else if (health == 2)
        {
            image.sprite = OneLives;
            healthBar = 2f;
        }

        else if (health == 3)
        {
            image.sprite = Empty;
        }
    }
    private void TakeDamage()
    {
        if (health == 0)
        {
            health++;
        }

        else if (health == 1)
        {
            health++;
        }

        else if (health == 2)
        {
            EndGame();
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
        WinGame.timerOn = false;
    }
}

