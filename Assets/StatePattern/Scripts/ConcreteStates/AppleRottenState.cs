using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleRottenState : AppleBaseState
{
    
    public override void EnterState(AppleStateManager apple)
    {
        apple.GetComponent<Renderer>().material.color = Color.yellow;
    }

    public override void OnCollisionEnter(AppleStateManager apple, Collision c)
    {
        Debug.Log("PlayerHealthDecrease");
    }

    public override void UpdateState(AppleStateManager apple)
    {
        
    }
}
