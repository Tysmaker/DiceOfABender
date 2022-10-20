using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using JetBrains.Annotations;

public static class SaveSystem 
{
    public static void SavePlayer (PlayerCharacter playerCharacter)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.test";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(playerCharacter);

        formatter.Serialize(stream, data);  
        stream.Close(); 
    }

    public static PlayerData LoadPlayer ()
    {
        string path = Application.persistentDataPath + "/player.test";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();
            Time.timeScale = 1f;
            return data;

        }

        else
        {   
            Debug.LogError("Save file not found in " + path);
            return null;
        } 
            
    }
    
}
