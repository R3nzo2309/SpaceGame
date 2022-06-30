using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    public Animator lightFlicker;

    internal void LightBulb()
    {
        float light = Random.Range(0, 2);
        
        if (light == 0)
        {
            lightFlicker.SetTrigger("Light1");
        }

        else if (light == 1)
        {
            lightFlicker.SetTrigger("Light2");
        }
    }

    internal void LightOn()
    {
        lightFlicker.SetTrigger("LightOn");
    }
}
