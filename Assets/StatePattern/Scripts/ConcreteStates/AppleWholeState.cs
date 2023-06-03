using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleWholeState : AppleBaseState
{
    float rottenCountDown = 10f;
    public override void EnterState(AppleStateManager apple)
    {
        apple.gameObject.GetComponent<Rigidbody>().useGravity = true;
    }
    public override void OnCollisionEnter(AppleStateManager apple, Collision c)
    {
        Debug.Log("PlayerHealthincrease");
        if (c.collider.tag=="Player")
        {
            apple.SwitchState(apple.ChewedState);
        }
       
    }
    public override void UpdateState(AppleStateManager apple)
    {
        if (rottenCountDown>=0)
        {
            rottenCountDown-=Time.deltaTime;
        }
        else
        {
            apple.SwitchState(apple.RottenState);
        }
    }
}
