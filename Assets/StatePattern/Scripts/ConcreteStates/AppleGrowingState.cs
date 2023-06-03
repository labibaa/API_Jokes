using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleGrowingState : AppleBaseState
{
    Vector3 appleStartSize = new Vector3(0.1f,0.1f,0.1f);
    Vector3 appleScaleSize = new Vector3(0.1f,0.1f,0.1f);
    Vector3 appleEndSize = new Vector3(1f,1f,1f);
    public override void EnterState(AppleStateManager apple)
    {
        apple.transform.localScale = appleStartSize;
    }

    public override void OnCollisionEnter(AppleStateManager apple, Collision c)
    {
        throw new System.NotImplementedException();
    }

    public override void UpdateState(AppleStateManager apple)
    {
        if (apple.transform.localScale.x<appleEndSize.x)
        {
            apple.transform.localScale += appleScaleSize * Time.deltaTime;
            
        }
        else
        {
            apple.SwitchState(apple.WholeState);
        }
    }
}
