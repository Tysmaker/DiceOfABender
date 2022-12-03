using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardDisplay : MonoBehaviour
{
    public Card card;

    
    public TMP_Text descriptionText;

    public Image elementImage;

    public TMP_Text attackText;
    // Start is called before the first frame update
    void Start()
    {
        descriptionText.text = card.description;
        elementImage.sprite = card.element;

        attackText.text = card.attack.ToString();
    }
}
