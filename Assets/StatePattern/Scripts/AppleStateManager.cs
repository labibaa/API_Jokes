using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleStateManager : MonoBehaviour
{

    AppleBaseState currentState;
    AppleChewedState chewedState = new AppleChewedState();
    AppleGrowingState growingState = new AppleGrowingState();
    AppleRottenState rottenState = new AppleRottenState();
    AppleWholeState wholeState = new AppleWholeState();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
