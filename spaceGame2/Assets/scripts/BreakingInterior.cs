using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakingInterior : MonoBehaviour
{
    private float timer = 0;
    private float secondTimer = 0;
    private float thirdTimer = 0;
    private float firstBreak = 30.0f;
    private float secondBreak = 45.0f;
    private float dead = 60.0f;

    private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite firstBreakSprite;
    [SerializeField] private Sprite secondBreakSprite;
    [SerializeField] private Sprite deadSprite;

    public static bool gameIsPaused = false;
    public GameObject LoseMenu;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GameObject.Find("/wall").GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        secondTimer += Time.deltaTime;
        thirdTimer += Time.deltaTime;

        if (timer >= firstBreak)
        {
            spriteRenderer.sprite = firstBreakSprite;
            Debug.Log("firstBreak");
        }
        if(secondTimer >= secondBreak)
        {
            spriteRenderer.sprite = secondBreakSprite;
            Debug.Log("secondBreak");
        }
        else if(thirdTimer >= dead)
        {
            spriteRenderer.sprite = deadSprite;
            Debug.Log("dead");
            timer = 0;
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
