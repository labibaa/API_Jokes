using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField]
    int score;
    private void OnEnable()
    {
        DetectCollision.OnEnterHex += IncreaseScore;
    }
    private void OnDisable()
    {
        DetectCollision.OnEnterHex -= IncreaseScore;
    }
    void IncreaseScore()
    {
        score++;
    }

    public int GetScore()
    {
        return score;
    }
}
