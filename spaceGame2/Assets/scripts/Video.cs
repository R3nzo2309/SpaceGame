using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Video : MonoBehaviour
{
    public VideoPlayer videoplayer;
    // Start is called before the first frame update
    void Start()
    {
        videoplayer = GetComponent<VideoPlayer>();
    }

    public void PlayVideo()
    {
        videoplayer.Play();
    }

}
