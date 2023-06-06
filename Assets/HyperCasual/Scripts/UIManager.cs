using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    Score score;
    [SerializeField]
    TextMeshProUGUI textMeshProUGUI;
    private void OnEnable()
    {
        DetectCollision.OnEnterHex += UpdateScoreUI;
    }
    private void OnDisable()
    {
        DetectCollision.OnEnterHex -= UpdateScoreUI;
    }

    private void UpdateScoreUI()
    {
        textMeshProUGUI.SetText(score.GetScore().ToString());
    }
}
