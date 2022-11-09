using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDataBase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    private void Awake()
    {
        cardList.Add(new Card(0, 0, "Blank: 0 Damage", Resources.Load<Sprite>("Blank")));
        cardList.Add(new Card(1, 10, "Tornado: 10 Damage", Resources.Load<Sprite>("Air")));
        cardList.Add(new Card(2, 10, "Boulder: 10 Damage", Resources.Load<Sprite>("Earth")));
        cardList.Add(new Card(3, 10, "Flood: 10 Damage", Resources.Load<Sprite>("Water")));
        cardList.Add(new Card(4, 10, "Fireball: 10 Damage", Resources.Load<Sprite>("Fire")));
        cardList.Add(new Card(5, 10, "Beam: 10 Damage", Resources.Load<Sprite>("Light")));
        cardList.Add(new Card(6, 10, "Void: 10 Damage", Resources.Load<Sprite>("Dark")));
    }
}
