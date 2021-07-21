using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    private AudioSource audSource;
    void Start()
    {
        audSource = GetComponent<AudioSource>();
        audSource.volume = (PlayerPrefs.GetFloat("MusicVolume", 5f)) / 10;
    }
    void Update()
    {
    }
    public void PlaySound(AudioClip music)
    {
        audSource.clip = music;
        audSource.Play();
    }
    public void SetVolume(float volume)
    {
        audSource.volume = (PlayerPrefs.GetFloat("MusicVolume", 5f)) / 10;
    }
}
