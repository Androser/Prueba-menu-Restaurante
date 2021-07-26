using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class EncenderLuz : MonoBehaviour, IPointerDownHandler, IPointerUpHandler 
{
    public GameObject LuzAEncender;
    public GameObject _On;
    public GameObject _Off;

    void IPointerDownHandler.OnPointerDown ( PointerEventData eventData )
    {
        LuzAEncender.SetActive ( true ); 
        _On.SetActive ( true ); 
        _Off.SetActive ( false ); 
    }

    void IPointerUpHandler.OnPointerUp ( PointerEventData eventData )
    {
        LuzAEncender.SetActive ( false );
        _On.SetActive ( false );
        _Off.SetActive ( true );
    }
}
