using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onTriggerTEMP : MonoBehaviour
{
    GameObject newTriggerObject;

    void OnTriggerEnter(Collider triggerObject)
    {
        if (triggerObject)
        {
            
            trigger();
            
            //newTriggerObject = triggerObject.gameObject;

            //access the newTriggerObjects script:
            //newTriggerObject.GetComponent<playerMovement>().triggerExampleFunction();
        }
    }
    void trigger()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("repairing");
        }
    }
}
