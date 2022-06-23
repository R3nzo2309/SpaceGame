using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour
{
    public Animator camAnim;

    internal void CamShake()
    {
        camAnim.SetTrigger("shake");
    }
}
