using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleChewedState : AppleBaseState
{
    float timeToDestroyApple = 5f;
    public override void EnterState(AppleStateManager apple)
    {
        Debug.Log("aplle done eating");
    }

    public override void OnCollisionEnter(AppleStateManager apple, Collision c)
    {
        throw new System.NotImplementedException();
    }

    public override void UpdateState(AppleStateManager apple)
    {
        if (timeToDestroyApple >= 0)
        {
            timeToDestroyApple-=Time.deltaTime;
        }
        else
        {
            Object.Destroy(apple.gameObject);
        }
    }


}
