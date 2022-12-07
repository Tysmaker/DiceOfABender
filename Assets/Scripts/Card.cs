using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card
{
<<<<<<< Updated upstream
    public int id;
    public int damage;

    public string description;

    public Sprite image;

    public Card()
    {

    }

    public Card(int Id, int Damage, string Description, Sprite Image)
    {
        id = Id;
        damage = Damage;
        description = Description;
        image = Image;
=======

    
    public string description;

    public Sprite element;

    public int attack;
    

    public void Print()
    {
        Debug.Log(description);
>>>>>>> Stashed changes
    }
}
