using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Michsky.UI.ModernUIPack;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    public static AudioController Instance { get; private set; }

    public AudioSource audioSource;
    public AudioClip Jokes;
    public AudioClip Aj;
    public AudioClip Facts;



    [SerializeField] Sprite soundOn;
    [SerializeField] Sprite soundOff;
    [SerializeField]Image image;

    [SerializeField] Image whirlIcon;
    float rotationSpeed = 180f;


    private void Awake()
    {
        Instance = this;

        audioSource = GetComponent<AudioSource>();

        audioSource.clip = Jokes;
        audioSource.Play();
    }

    public void PlayAudio(AudioClip audioClip)
    {
        audioSource.clip = audioClip;
        audioSource.Play();
    }


    public void ToggleAudio()
    {

        if (audioSource.isPlaying)
        {

            image.sprite = soundOff;
            
            audioSource.Stop();
        }
        else
        {
            image.sprite = soundOn;
            audioSource.Play();
        }

    }


    public void Whirl()
    {

        whirlIcon.rectTransform.Rotate(new Vector3(0, 0, rotationSpeed));
    }


}
