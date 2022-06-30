using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Animator Door;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Door.SetTrigger("open");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Door.SetTrigger("close");
    }
}
