using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RUDE : MonoBehaviour
{
    public void QuitGame()
    {
        //put the debug log so that i know the quit button is working
        //because it wont just quit the game while running in unity
        Debug.Log("RUDE");
        Application.Quit();
        //im not actually upset. but still?
        //have some compassion for someone learning their passion
    }
}
