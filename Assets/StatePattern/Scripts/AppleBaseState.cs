using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public abstract class AppleBaseState 
{
    public abstract void EnterState(AppleStateManager apple);
    public abstract void UpdateState(AppleStateManager apple);
    public abstract void OnCollisionEnter(AppleStateManager apple);




}
