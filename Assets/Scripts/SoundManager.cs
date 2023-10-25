using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance {get; private set;}

    [SerializeField]AudioSource _sfxAudioSource;

    [SerializeField]private AudioClip deathSound;

   void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }

        _sfxAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Death()
    {
        _sfxAudioSource.PlayOneShot(deathSound);
    }
}
