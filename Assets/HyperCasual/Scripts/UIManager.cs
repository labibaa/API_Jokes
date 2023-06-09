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
    TextMeshProUGUI scoreText;
    [SerializeField]
    TextMeshProUGUI highScoreText;
    private void OnEnable()
    {
        DetectCollision.OnEnterHex += UpdateScoreUI;
        Score.OnHighScoreChange += UpdateHighScoreUI;
    }
    private void OnDisable()
    {
        DetectCollision.OnEnterHex -= UpdateScoreUI;
        Score.OnHighScoreChange -= UpdateHighScoreUI;
    }

    private void UpdateScoreUI()
    {
        scoreText.SetText(score.GetScore().ToString());
    }

    private void UpdateHighScoreUI(int highScore)
    {
        highScoreText.SetText(highScore.ToString());
    }
}
