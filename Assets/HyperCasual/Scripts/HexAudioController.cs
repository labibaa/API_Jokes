using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexAudioController : MonoBehaviour
{
   public static HexAudioController instance;
   AudioSource m_AudioSource;
    public AudioClip Scored;
    public AudioClip HighScored;
    public AudioClip Damaged;


    private void Awake()
    {
        instance = this;
        m_AudioSource = GetComponent<AudioSource>();
    }

    public void PlayAudio(AudioClip audioClip)
    {
        // m_AudioSource.clip = audioClip;
        m_AudioSource.PlayOneShot(audioClip);
    }
}
