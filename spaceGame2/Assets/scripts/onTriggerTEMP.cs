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
    [SerializeField] private string background;

    private bool lever1Trigger = false;
    private bool lever2Trigger = false;
    private bool lever3Trigger = false;
    private bool lever4Trigger = false;
    private bool lever5Trigger = false;
    private bool lever6Trigger = false;
    private bool lever7Trigger = false;
    private bool lever8Trigger = false;

    private bool light1 = false;
    private bool light2 = false;
    private bool light3 = false;
    private bool light4 = false;
    private bool light5 = false;

    private bool medic1 = false;
    private bool medic2 = false;

    private float timer = 0;
    private float waitingTime = 1.0f;

     private SpriteRenderer sr;
    [SerializeField] private Sprite lightsOn;

    [SerializeField] private GameObject lostSignal;
    [SerializeField] private GameObject Damage;


    private void Start()
    {
        sr = GameObject.FindWithTag("background").GetComponent<SpriteRenderer>();
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
        if(light1 && light2 && light3 && light4 && light5)
        {
            sr.sprite = lightsOn;
            lostSignal.SetActive(false);
        }

        if(medic1 && medic2)
        {
            Damage.SetActive(false);
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
                    Destroy(GameObject.FindWithTag("lever1"));
                    light1 = true;
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
                    Destroy(GameObject.FindWithTag("lever2"));
                    light2 = true;
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
                    Destroy(GameObject.FindWithTag("lever3"));
                    light3 = true;
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
                    Destroy(GameObject.FindWithTag("lever4"));
                    light4 = true;
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
                    Destroy(GameObject.FindWithTag("lever5"));
                    light5 = true;
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
                    Destroy(GameObject.FindWithTag("lever6"));
                    medic1 = true;
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
                    Destroy(GameObject.FindWithTag("lever7"));
                    medic2 = true;
                }
            }
        }
        if (lever8Trigger == true)
        {
            if (Input.GetKey(KeyCode.E))
            {
                if (Input.GetKey(KeyCode.E))
                {
                    Debug.Log("entered cockpit");
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
                }
            }
        }
    }
}
