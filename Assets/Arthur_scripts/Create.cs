using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Create : MonoBehaviour, IBeginDragHandler
{
    public GameObject tower;
    public void OnBeginDrag(PointerEventData eventData)
    {
        Instantiate(tower, eventData.pointerCurrentRaycast.worldPosition, Quaternion.identity);
    }
}
