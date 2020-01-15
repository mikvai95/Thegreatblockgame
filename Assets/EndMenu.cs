using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public void restartGame()
    {
        SceneManager.LoadScene("taso1");
    }

    public void returnToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
