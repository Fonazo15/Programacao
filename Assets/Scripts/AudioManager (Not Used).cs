using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public List<AudioClip> clips;
    private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }
                //      \/ This \/ is for when another script acess this function, we'll have a shorter way for specifing which clip to play
    public void PlayClip(int clip)
    {
        switch (clip)
        {
            case 0:
                _audioSource.PlayOneShot(clips[0]); break;
            case 1:
                _audioSource.PlayOneShot(clips[1]); break;
            case 2:
                _audioSource.PlayOneShot(clips[2]); break;
        }
    }
}
