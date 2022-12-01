
using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class SoundSelect : MonoBehaviour, IPointerEnterHandler
{
    
    // The mouse was released from the GameObject.
    public void OnPointerEnter(PointerEventData eventData)
    {
        AudioManager.instance.Play("SelectLevel");

        Debug.Log(this.gameObject.name + " Was Clicked.");



    }
    void Start ()
    {
        
    }
}
