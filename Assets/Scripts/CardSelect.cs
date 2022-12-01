using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class CardSelect : MonoBehaviour, IPointerEnterHandler
{

    

    public void OnPointerEnter(PointerEventData eventData)
    {
        AudioManager.instance.Play("ChooseCard");

        Debug.Log(this.gameObject.name + " Was Clicked.");



    }








}

