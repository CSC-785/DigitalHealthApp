using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class playPause : MonoBehaviour
{
    public VideoPlayer video;
    public GameObject buton;
    private float segue;

    private void Awake()
    {

        video = GetComponent<VideoPlayer>();

    }

    private void Start()
    {
        //var frameZero = 0;
        //vid1.frame = (long)frameZero;
        video.Play();
    }

    private void Update()

    {


        if (video.frame == 200)
        {
            video.Pause();
            video.frame = 201;

        }
        Debug.Log("frame" + video.frame);
    }


    public void acerta()
    {


        //var frame = segue;
        //vid1.frame = (long)frame ;
        video.Play();
    }
}

