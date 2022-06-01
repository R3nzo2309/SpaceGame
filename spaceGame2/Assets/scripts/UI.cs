using UnityEngine;
using UnityEngine.UI;
using System.Collections;

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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject)
        {

            if (imgNumberCount == 0)
            {
                GameObject.Find("/Canvas/player-info/health").GetComponent<Image>().sprite = TwoLives;
                imgNumberCount++;
                Destroy(collision.gameObject);
            }

            else if (imgNumberCount == 1)
            {
                GameObject.Find("/Canvas/player-info/health").GetComponent<Image>().sprite = OneLives;
                imgNumberCount++;
                Destroy(collision.gameObject);
            }

            else if (imgNumberCount == 2)
            {
                GameObject.Find("/Canvas/player-info/health").GetComponent<Image>().sprite = Empty;
                Destroy(collision.gameObject);
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
    }
}

