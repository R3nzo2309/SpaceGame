using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenHatch : MonoBehaviour
{
    public Animator Hatch;

    private bool trigger = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        trigger = true;
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        trigger = false;
        Hatch.SetTrigger("close");
    }

    private void Update()
    {
        if(trigger == true)
        {
            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.W))
            {
                Hatch.SetTrigger("open");
            }
        }
    }
}
