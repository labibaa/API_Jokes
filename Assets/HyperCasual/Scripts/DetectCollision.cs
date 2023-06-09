using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DetectCollision : MonoBehaviour
{
    public static event Action OnEnterHex;
    public static event Action OnCollideHex;
    [SerializeField]
    GameObject burstBubble;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Hex"))
        {
            SpawnAndPlayParticleSystem(Color.black);
            OnCollideHex?.Invoke();
            Destroy(this.gameObject);
            HexAudioController.instance.PlayAudio(HexAudioController.instance.Damaged);
           
        }
        else if (collision.CompareTag("Open"))
        {
            SpawnAndPlayParticleSystem(Color.white);
            OnEnterHex?.Invoke();
            Destroy(this.gameObject);
            HexAudioController.instance.PlayAudio(HexAudioController.instance.Scored);
        }

       
    }


    public void SpawnAndPlayParticleSystem(Color color)
    {
        GameObject particleObject = Instantiate(burstBubble,transform.position,Quaternion.identity);
        ParticleSystem particleSystem = particleObject.GetComponent<ParticleSystem>();
        ParticleSystem.MainModule particleMainModule;
        particleMainModule = particleSystem.main;
        particleMainModule.startColor = color;
        particleSystem.Play();
    }
}
