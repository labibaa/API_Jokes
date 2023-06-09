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
        
        
    }
    private void Start()
    {
        highScore = SaveData.instance.DeSerializeJson();
        OnHighScoreChange?.Invoke(highScore);
    }

    private void OnEnable()
    {
        DetectCollision.OnEnterHex += IncreaseScore;
        DetectCollision.OnCollideHex += DecreaseScore;
    }
    private void OnDisable()
    {
        DetectCollision.OnEnterHex -= IncreaseScore;
        DetectCollision.OnCollideHex -= DecreaseScore;
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

    void DecreaseScore()
    {
        score--;
        if(score<0)
        {
            score = 0;
            UIManager.instance.Activatepanel();
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
