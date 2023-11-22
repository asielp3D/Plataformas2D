using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMManager : MonoBehaviour
{
    AudioSource source;

    public AudioClip bgmMusic;
    
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        source = GetComponent<AudioSource>();

        source.clip = bgmMusic;
        source.Play();
    }

    public void StopBGM()
    {
        source.Stop();
    }
}
