using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onTriggerTEMP : MonoBehaviour
{

    [SerializeField] private string lever1;
    [SerializeField] private string lever2;
    [SerializeField] private string lever3;
    [SerializeField] private string lever4;
    [SerializeField] private string lever5;
    [SerializeField] private string lever6;
    [SerializeField] private string lever7;
    [SerializeField] private string lever8;

    private bool lever1Trigger = false;
    private bool lever2Trigger = false;
    private bool lever3Trigger = false;
    private bool lever4Trigger = false;
    private bool lever5Trigger = false;
    private bool lever6Trigger = false;
    private bool lever7Trigger = false;
    private bool lever8Trigger = false;

    private float timer = 0;
    private float waitingTime = 1.0f;

    private SpriteRenderer spriteRenderer;
    [SerializeField] private SpriteRenderer leverColor1;
    [SerializeField] private SpriteRenderer leverColor2;
    [SerializeField] private SpriteRenderer leverColor3;
    [SerializeField] private SpriteRenderer leverColor4;
    [SerializeField] private SpriteRenderer leverColor5;
    [SerializeField] private SpriteRenderer leverColor6;
    [SerializeField] private SpriteRenderer leverColor7;
    [SerializeField] private SpriteRenderer leverColor8;
    [SerializeField] private Sprite backgroundChange;


    [SerializeField] private SpriteRenderer holeOne;
    [SerializeField] private SpriteRenderer holeTwo;
    [SerializeField] private SpriteRenderer holeThree;


    private void Start()
    {
        holeOne = GameObject.Find("hole-1").GetComponent<SpriteRenderer>();
        holeTwo = GameObject.Find("hole-2").GetComponent<SpriteRenderer>();
        holeThree = GameObject.Find("hole-3").GetComponent<SpriteRenderer>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(lever1))
        {
            lever1Trigger = true;
        }
        if (collision.gameObject.CompareTag(lever2))
        {
            lever2Trigger = true;
        }
        if (collision.gameObject.CompareTag(lever3))
        {
            lever3Trigger = true;
        }
        if (collision.gameObject.CompareTag(lever4))
        {
            lever4Trigger = true;
        }
        if (collision.gameObject.CompareTag(lever5))
        {
            lever5Trigger = true;
        }
        if (collision.gameObject.CompareTag(lever6))
        {
            lever6Trigger = true;
        }
        if (collision.gameObject.CompareTag(lever7))
        {
            lever7Trigger = true;
        }
        if (collision.gameObject.CompareTag(lever8))
        {
            lever8Trigger = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(lever1))
        {
            lever1Trigger = false;
            timer = 0;
        }
        if (collision.gameObject.CompareTag(lever2))
        {
            lever2Trigger = false;
            timer = 0;
        }
        if (collision.gameObject.CompareTag(lever3))
        {
            lever3Trigger = false;
            timer = 0;
        }
        if (collision.gameObject.CompareTag(lever4))
        {
            lever4Trigger = false;
            timer = 0;
        }
        if (collision.gameObject.CompareTag(lever5))
        {
            lever5Trigger = false;
            timer = 0;
        }
        if (collision.gameObject.CompareTag(lever6))
        {
            lever6Trigger = false;
            timer = 0;
        }
        if (collision.gameObject.CompareTag(lever7))
        {
            lever7Trigger = false;
            timer = 0;
        }
        if (collision.gameObject.CompareTag(lever8))
        {
            lever8Trigger = false;
            timer = 0;
        }
    }
    private void Update()
    {
        if (leverColor1.color == Color.green && leverColor2.color == Color.green && leverColor3.color == Color.green && leverColor4.color == Color.green && leverColor5.color == Color.green)
        {
            Debug.Log("repaired lights");
            leverColor1.color = Color.blue;
        }

        if (leverColor6.color == Color.green && leverColor7.color == Color.green)
        {
            Debug.Log("repaired medic");
            leverColor6.color = Color.blue;
        }

        if (lever1Trigger == true)
        {
            if (Input.GetKey(KeyCode.E))
            {
                timer += Time.deltaTime;

                if (timer >= waitingTime)
                {
                    Debug.Log("repaired lever 1");
                    timer = 0;
                    leverColor1.color = Color.green;
                }
            }
        }
        if (lever2Trigger == true)
        {
            if (Input.GetKey(KeyCode.E))
            {
                timer += Time.deltaTime;

                if (timer >= waitingTime)
                {
                    Debug.Log("repaired lever 2");
                    timer = 0;
                    leverColor2.color = Color.green;
                }
            }
        }
        if (lever3Trigger == true)
        {
            if (Input.GetKey(KeyCode.E))
            {
                timer += Time.deltaTime;

                if (timer >= waitingTime)
                {
                    Debug.Log("repaired lever 3");
                    timer = 0;
                    leverColor3.color = Color.green;
                }
            }
        }
        if (lever4Trigger == true)
        {
            if (Input.GetKey(KeyCode.E))
            {
                timer += Time.deltaTime;

                if (timer >= waitingTime)
                {
                    Debug.Log("repaired lever 4");
                    timer = 0;
                    leverColor4.color = Color.green;
                }
            }
        }
        if (lever5Trigger == true)
        {
            if (Input.GetKey(KeyCode.E))
            {
                timer += Time.deltaTime;

                if (timer >= waitingTime)
                {
                    Debug.Log("repaired lever 5");
                    timer = 0;
                    leverColor5.color = Color.green;
                }
            }
        }
        if (lever6Trigger == true)
        {
            if (Input.GetKey(KeyCode.E))
            {
                timer += Time.deltaTime;

                if (timer >= waitingTime)
                {
                    Debug.Log("repaired lever 6");
                    timer = 0;
                    leverColor6.color = Color.green;
                }
            }
        }
        if (lever7Trigger == true)
        {
            if (Input.GetKey(KeyCode.E))
            {
                timer += Time.deltaTime;

                if (timer >= waitingTime)
                {
                    Debug.Log("repaired lever 7");
                    timer = 0;
                    leverColor7.color = Color.green;
                }
            }
        }
        if (lever8Trigger == true)
        {

            Destroy(holeOne);
            Destroy(holeTwo);
            Destroy(holeThree);

            if (Input.GetKey(KeyCode.E))
            {
                Debug.Log("entered cockpit");
                leverColor8.color = Color.green;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            }
        }
    }
}
