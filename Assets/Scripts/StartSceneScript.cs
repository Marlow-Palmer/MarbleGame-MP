using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneScript : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("MainGameScene");
    }

    public void QuitGame()
    {
        //put the debug log so that i know the quit button is working
        //because it wont just quit the game while running in unity
        Debug.Log("Quit");
        Application.Quit();
    }
}
