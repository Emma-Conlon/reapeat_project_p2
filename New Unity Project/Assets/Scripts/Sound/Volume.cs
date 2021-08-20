﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volume : MonoBehaviour
{
    public AudioSource AudioSource;

    public float musicVolume = 1f;
    void Start()
    {
        AudioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        AudioSource.volume = musicVolume;
    }
    public void updateVolume(float volume)
    {
        musicVolume = volume;
    }
}

