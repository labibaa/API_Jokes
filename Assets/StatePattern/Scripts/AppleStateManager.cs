using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleStateManager : MonoBehaviour
{

    public AppleBaseState CurrentState;
    public AppleChewedState ChewedState = new AppleChewedState();
    public AppleGrowingState GrowingState = new AppleGrowingState();
    public AppleRottenState RottenState = new AppleRottenState();
    public AppleWholeState WholeState = new AppleWholeState();

    // Start is called before the first frame update
    void Start()
    {
        CurrentState = GrowingState;//setting the first state to be the growing state
        CurrentState.EnterState(this);
    }

    // Update is called once per frame
    void Update()
    {
        CurrentState.UpdateState(this);
    }


    public void SwitchState(AppleBaseState state)
    {
        CurrentState = state;
        CurrentState.EnterState(this);
    }


    private void OnCollisionEnter(Collision collision)
    {
        CurrentState.OnCollisionEnter(this,collision);
    }
}
