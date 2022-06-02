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
            
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("repairing");
            }
            newTriggerObject = triggerObject.gameObject;

            //access the newTriggerObjects script:
            //newTriggerObject.GetComponent<playerMovement>().triggerExampleFunction();
        }
    }
}
