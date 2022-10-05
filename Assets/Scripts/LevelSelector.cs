using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using System;
using System.Reflection;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class LevelSelector : MonoBehaviour
{

    public TextMeshProUGUI levelText;

    [SerializeField]
    public string scenePath;

    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            levelText.gameObject.SetActive(true);
            LevelSelection();
        }        
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            levelText.gameObject.SetActive(false);
        }
    }

   public void LevelSelection()
    {
        if(Input.GetKeyUp(KeyCode.E))
        {
            SceneManager.LoadScene(scenePath);
        }
    }
}



    





