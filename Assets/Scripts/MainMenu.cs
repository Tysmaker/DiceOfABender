using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void LoadScene()
    {
        SceneManager.LoadScene("LevelSelector");
        PlayerPrefs.DeleteAll();

    }

    public void SaveGame()
    {
        
    }

    public void LoadGame()
    {

    }


    public void QuitGame()
    {
        Debug.Log("Quitting Game");

    }
}
