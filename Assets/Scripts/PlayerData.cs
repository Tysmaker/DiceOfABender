using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class PlayerData 
{
    public int level = SceneManager.GetActiveScene().buildIndex;
    public int currentHealth;
   

    public PlayerData (PlayerCharacter playerCharacter)
    {
        level = playerCharacter.level;  
        //currentHealth = playerCharacter.currentHealth;
    }
}
   