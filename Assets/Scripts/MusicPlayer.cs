using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioClip backgroundMusic;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

        // Load the background music
        audioSource.clip = backgroundMusic;

        // Set the audio source to loop
        audioSource.loop = true;

        // Play the music
        audioSource.Play();
    }
}
