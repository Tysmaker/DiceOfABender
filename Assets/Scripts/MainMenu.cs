using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void LoadScene()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Debug.Log("Quitting Game");

    }
}