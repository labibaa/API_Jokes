using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DetectCollision : MonoBehaviour
{
    public static event Action OnEnterHex;
    public static event Action OnCollideHex;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Hex"))
        {
            OnCollideHex?.Invoke();
            Destroy(this.gameObject);
        }
        else if (collision.CompareTag("Open"))
        {
            OnEnterHex?.Invoke();
            Destroy(this.gameObject);
        }

       
    }
}
