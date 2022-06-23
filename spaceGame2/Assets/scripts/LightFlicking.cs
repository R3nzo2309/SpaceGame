using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicking : MonoBehaviour
{
    public Animator lAnim;

    internal void LFlicking()
    {
        int rnd = Random.Range(0, 3);
        if (rnd == 0)
        {
           
        }
        else if (rnd == 1)
        {
            lAnim.SetTrigger("Light2");
        }
        else if (rnd == 2)
        {
            lAnim.SetTrigger("Light3");
        }
    }

    internal void StopAnima()
    {
        lAnim.SetTrigger("done");
    }
}
