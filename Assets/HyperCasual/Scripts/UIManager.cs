using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    [SerializeField]
    Score score;
    [SerializeField]
    TextMeshProUGUI scoreText;
    [SerializeField]
    TextMeshProUGUI highScoreText;
    [SerializeField]
    GameObject gameOverPanel;

    private void Awake()
    {
        instance = this;
    }
    private void OnEnable()
    {
        DetectCollision.OnEnterHex += UpdateScoreUI;
        DetectCollision.OnCollideHex += UpdateScoreUI;
        Score.OnHighScoreChange += UpdateHighScoreUI;
    }
    private void OnDisable()
    {
        DetectCollision.OnEnterHex -= UpdateScoreUI;
        DetectCollision.OnCollideHex -= UpdateScoreUI;
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

    public void Activatepanel()
    {
        Time.timeScale = 0;
        gameOverPanel.SetActive(true);
    }
}
