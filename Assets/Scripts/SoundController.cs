using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    private AudioSource audSource;
    void Start()
    {
        audSource = GetComponent<AudioSource>();
        audSource.volume = .5f;
    }
    void Update()
    {
    }
    public void PlaySound(AudioClip sound)
    { 
        audSource.clip = sound;
        audSource.Play();
    }
}
