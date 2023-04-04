using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinuePause : MonoBehaviour
{
    public void OkayButton()
    {
        SceneManager.LoadScene("PauseScene");
    }

    public void NotOkayButton()
    {
        SceneManager.LoadScene("RudeScene");
    }
}
