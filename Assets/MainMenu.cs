using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("taso1");
    }

    public void ShowHelp()
    {
        SceneManager.LoadScene("Help Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
