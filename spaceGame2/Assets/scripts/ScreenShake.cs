using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour
{
    public Animator camAnim;
    public Animator anime;

    internal void CamShake()
    {
        camAnim.SetTrigger("shake");
        anime.SetTrigger("Hit");
    }
}
