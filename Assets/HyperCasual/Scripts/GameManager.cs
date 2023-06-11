using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject panel;
    public void RestartScene()
    {
        Time.timeScale = 1.0f;
        panel.SetActive(false);
        Scene currentScene = SceneManager.GetActiveScene();

        // Reload the current scene by using its build index
        SceneManager.LoadScene(currentScene.buildIndex);
    }
}
