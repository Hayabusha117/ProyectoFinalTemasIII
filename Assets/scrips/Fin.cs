﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class Fin : MonoBehaviour
{
    public VideoPlayer video;
    // Start is called before the first frame update
    void Awake()
    {
        video = GetComponent<VideoPlayer>();
        video.Play();
        video.loopPointReached += CheckOver;

    }

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CheckOver(VideoPlayer vp)
    {
        SceneManager.LoadScene("MainMenu");
    }
}
