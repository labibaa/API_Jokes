using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class DTAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnEnable()
    {
        transform.localScale = Vector3.zero;

       
        transform.DOScale(Vector3.one, 0.3f)
            .SetEase(Ease.OutBack)
            .SetDelay(0.1f)
            .SetLoops(2, LoopType.Yoyo);
    }
}
