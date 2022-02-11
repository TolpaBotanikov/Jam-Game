using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Tyrel : MonoBehaviour, IDragHandler, IBeginDragHandler, IPointerClickHandler
{
    public void OnBeginDrag(PointerEventData eventData)
    {
        transform.position = eventData.pointerCurrentRaycast.worldPosition;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.pointerCurrentRaycast.worldPosition;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Camera.main.WorldToScreenPoint(eventData.position);
        print(eventData.position);
    }
}
