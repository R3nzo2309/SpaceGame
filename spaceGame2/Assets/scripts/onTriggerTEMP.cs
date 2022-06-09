using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onTriggerTEMP : MonoBehaviour
{

    [SerializeField] private string lever1;
    [SerializeField] private string lever2;
    [SerializeField] private string lever3;
    [SerializeField] private string lever4;
    [SerializeField] private string lever5;
    [SerializeField] private string lever6;
    [SerializeField] private string lever7;

    private bool lever1Trigger = false;
    private bool lever2Trigger = false;
    private bool lever3Trigger = false;
    private bool lever4Trigger = false;
    private bool lever5Trigger = false;
    private bool lever6Trigger = false;
    private bool lever7Trigger = false;

    private float timer = 0;
    private float waitingTime = 1.0f;

    private SpriteRenderer spriteRenderer;
    private SpriteRenderer leverColor1;
    private SpriteRenderer leverColor2;
    private SpriteRenderer leverColor3;
    private SpriteRenderer leverColor4;
    private SpriteRenderer leverColor5;
    private SpriteRenderer leverColor6;
    private SpriteRenderer leverColor7;
    [SerializeField] private Sprite backgroundChange;

    private void Start()
    {
        spriteRenderer = GameObject.Find("/wall").GetComponent<SpriteRenderer>();
        leverColor1 = GameObject.Find("/lever1 (lights)/circle").GetComponent<SpriteRenderer>();
        leverColor2 = GameObject.Find("/lever2 (lights)/circle").GetComponent<SpriteRenderer>();
        leverColor3 = GameObject.Find("/lever3 (lights)/circle").GetComponent<SpriteRenderer>();
        leverColor4 = GameObject.Find("/lever4 (lights)/circle").GetComponent<SpriteRenderer>();
        leverColor5 = GameObject.Find("/lever5 (lights)/circle").GetComponent<SpriteRenderer>();
        leverColor6 = GameObject.Find("/lever6 (medic)/circle").GetComponent<SpriteRenderer>();
        leverColor7 = GameObject.Find("/lever7 (medic)/circle").GetComponent<SpriteRenderer>();
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
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(lever1))
        {
            lever1Trigger = false;
        }
        if (collision.gameObject.CompareTag(lever2))
        {
            lever2Trigger = false;
        }
        if (collision.gameObject.CompareTag(lever3))
        {
            lever3Trigger = false;
        }
        if (collision.gameObject.CompareTag(lever4))
        {
            lever4Trigger = false;
        }
        if (collision.gameObject.CompareTag(lever5))
        {
            lever5Trigger = false;
        }
        if (collision.gameObject.CompareTag(lever6))
        {
            lever6Trigger = false;
        }
        if (collision.gameObject.CompareTag(lever7))
        {
            lever7Trigger = false;
        }
        timer = 0;
    }
    private void Update()
    {
        if (leverColor1.color == Color.green && leverColor2.color == Color.green && leverColor3.color == Color.green && leverColor4.color == Color.green && leverColor5.color == Color.green)
        {
            Debug.Log("repaired 5 levers");
            //spriteRenderer.sprite = backgroundChange;
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
    }
}
