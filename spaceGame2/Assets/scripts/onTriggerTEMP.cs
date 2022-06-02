using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onTriggerTEMP : MonoBehaviour
{

    public string tagObjective;
    private bool isOnTrigger = false;

    private float timer = 0;
    private float waitingTime = 5.0f;

    private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite square;

    private void Start()
    {
        spriteRenderer = GameObject.Find("/wall").GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(tagObjective))
        {
            isOnTrigger = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isOnTrigger = false;
        timer = 0;
    }
    private void Update()
    {
        if (isOnTrigger == true)
        {
            if (Input.GetKey(KeyCode.E))
            {
                timer += Time.deltaTime;

                if (timer >= waitingTime)
                {
                    Debug.Log("repaired");
                    timer = 0;
                    spriteRenderer.sprite = square;
                }
            }
        }
    }
}
