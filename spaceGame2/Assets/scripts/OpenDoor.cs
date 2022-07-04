using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Animator Door;
    public AudioSource doorOpening;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Door.SetTrigger("open");
        doorOpening.Play();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Door.SetTrigger("close");
        doorOpening.Play();
    }
}
