using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    private AudioSource audSource;
    void Start()
    {
        audSource = GetComponent<AudioSource>();
        audSource.volume = (PlayerPrefs.GetFloat("SoundVolume", 5f)) / 10;
    }
    void Update()
    {
    }
    public void PlaySound(AudioClip sound)
    { 
        audSource.clip = sound;
        audSource.Play();
    }
    public void SetVolume(float volume)
    {
        audSource.volume = (PlayerPrefs.GetFloat("SoundVolume", 5f)) / 10;
    }
}
