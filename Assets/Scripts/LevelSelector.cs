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
    public Button[] buttons;

    public TextMeshProUGUI levelText;

    [SerializeField]
   public string scenePath;

    void Start()
    {

        int levelAt = PlayerPrefs.GetInt("levelAt", 2);

        for (int i = 0; i < buttons.Length; i++)
        {

            if (i + 2 > levelAt)
            {
                buttons[i].interactable = false;
            }
        }

        


    }

     public void OnTriggerStay2D(Collider2D other)
     {
         if (other.gameObject.tag == "Player")
         {

             levelText.gameObject.SetActive(true);
             //LevelSelection();
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
        // if(Input.GetKey(KeyCode.E))
         {
            AudioManager.instance.Play("SelectLevel");
            
             

        }
     }

     
}









