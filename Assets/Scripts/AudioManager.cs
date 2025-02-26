using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip destructClip;
    public AudioClip scoreClip;
    public AudioClip swipeClip;

    public void PlayDestruct()
    {
        audioSource.PlayOneShot(destructClip);
    }
    public void PlayScore()
    {
        audioSource.PlayOneShot(scoreClip);
    }
    public void PlaySwipe()
    {
        audioSource.PlayOneShot(swipeClip);
    }
}
