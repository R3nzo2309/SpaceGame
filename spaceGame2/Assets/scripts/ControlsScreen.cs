using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsScreen : MonoBehaviour
{
    public GameObject controlsMenu;
    public static bool controlsOpen = true;
    // Start is called before the first frame update
    void Start()
    {
        if(controlsOpen == true)
        {
            ControlsOpen();
        }
        else if(controlsOpen == false)
        {
            ControlsClosed();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            ControlsClosed();
        }
    }

    private void ControlsOpen()
    {
        controlsMenu.SetActive(true);
        Time.timeScale = 0f;
        AudioListener.pause = true;
        Cursor.visible = true;
        controlsOpen = true;
    }

    private void ControlsClosed()
    {
        controlsMenu.SetActive(false);
        Time.timeScale = 1f;
        AudioListener.pause = false;
        Cursor.visible = false;
        controlsOpen = false;
    }
}
