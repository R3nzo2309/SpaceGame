using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public Sprite Full;
    public Sprite TwoLives;
    public Sprite OneLives;
    public Sprite Empty;

    public SpriteRenderer spriteRenderer;

    public float imgNumberCount = 0;

    public static bool gameIsPaused = false;
    public GameObject LoseMenu;

    private Image image;
    private PlayerInfo playerInfo;

    private void Start()
    {
        image = GameObject.Find("/Canvas/player-info/health").GetComponent<Image>();
        playerInfo = GameObject.Find("PlayerInfo").GetComponent<PlayerInfo>();
        UpdateHealth();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject)
        {
            playerInfo.playerHealth -= 1;
            UpdateHealth();
            Destroy(collision.gameObject);
       
        }
    }

    private void UpdateHealth()
    {
        if (playerInfo.playerHealth == 3)
        {
            image.sprite = Full;
            imgNumberCount++;
        }
        if (playerInfo.playerHealth == 2)
        {
            image.sprite = TwoLives;
            imgNumberCount++;
        }

        else if (playerInfo.playerHealth == 1)
        {
            image.sprite = OneLives;
            imgNumberCount++;
        }

        else if (playerInfo.playerHealth == 0)
        {
            image.sprite = Empty;
            EndGame();
        }
    }
    void EndGame()
    {
        LoseMenu.SetActive(true);
        Time.timeScale = 0f;
        AudioListener.pause = true;
        gameIsPaused = true;
        Cursor.visible = true;
    }
    private void Update()
    {
       
    }
}

