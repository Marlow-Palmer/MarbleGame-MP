using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainGameScript : MonoBehaviour
{
    public void PauseButton()
    {
        SceneManager.LoadScene("PauseScene");
    }
}
