using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class DisplayCard : MonoBehaviour
{
    public List<Card> displayCard = new List<Card>();

    public int displayId;
    public int id;

    public string description;

    public Sprite image;

    public TextMeshProUGUI descriptionText;

    public Image cardImage;

    // Start is called before the first frame update
    void Start()
    {
        displayCard[0] = CardDataBase.cardList[displayId];
        id = displayCard[0].id;
        description = displayCard[0].description;
        image = displayCard[0].image;

        descriptionText.text = description;
        cardImage.sprite = image;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
