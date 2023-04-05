using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public void BackToStartButton()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("MainGameScene");
    }

    public void ContinueButton()
    {
        SceneManager.LoadScene("MainGameScene");
    }
}
