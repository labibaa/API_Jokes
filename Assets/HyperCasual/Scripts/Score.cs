using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Score : MonoBehaviour
{
    [SerializeField]
    int score;
    [SerializeField]
    int highScore;

    public static event Action<int> OnHighScoreChange;
    private void Awake()
    {
        highScore = SaveData.instance.DeSerializeJson();
        
    }
    private void Start()
    {
        OnHighScoreChange?.Invoke(highScore);
    }

    private void OnEnable()
    {
        DetectCollision.OnEnterHex += IncreaseScore;
    }
    private void OnDisable()
    {
        DetectCollision.OnEnterHex -= IncreaseScore;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            ClearhighScore();
        }
    }

    void IncreaseScore()
    {
        score++;
        if (score>highScore)
        {
            highScore = score;
            SaveData.instance.SerializeJson(highScore);
            OnHighScoreChange?.Invoke(highScore);
        }
    }

    public int GetScore()
    {
        return score;
    }

    public int GetHighScore()
    {

        return highScore;
    }

    void ClearhighScore()
    {
        highScore = 0;
        score = 0;
        SaveData.instance.SerializeJson(highScore);
        
        OnHighScoreChange?.Invoke(highScore);
    }

}
