using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Tyrel : MonoBehaviour, IDragHandler, IBeginDragHandler
{
    public Vector2[] coor;
    private Vector3 start;
    public void OnBeginDrag(PointerEventData eventData)
    {
        start = transform.position; 
        transform.position = eventData.pointerCurrentRaycast.worldPosition;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector3 move = eventData.pointerCurrentRaycast.worldPosition;
        move.y = 0f;
        transform.position = move;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Vector3 pos = eventData.pointerCurrentRaycast.worldPosition;
        float xcir = Mathf.Round(pos.x);
        float zcir = Mathf.Round(pos.z);
        if (xcir > pos.x)
        {
            xcir -= 0.5f;
        }
        else if (xcir < pos.x)
        {
            xcir += 0.5f;
        }
        if (zcir > pos.z)
        {
            zcir -= 0.5f;
        }
        else if (zcir < pos.z)
        {
            zcir += 0.5f;
        }
        foreach (Vector2 i in this.GetComponent<Tyrel>().coor)
        {
            if (Create.placeActive.Contains((new Vector2(xcir, zcir) + i)))
            {
                xcir = start.x;
                zcir = start.z;
            }
        }
        foreach (Vector2 i in this.GetComponent<Tyrel>().coor)
        {
            Create.placeActive.Remove(new Vector2(transform.position.x, transform.position.z) + i);
        }
        foreach (Vector2 i in this.GetComponent<Tyrel>().coor)
        {
            Create.placeActive.Add(new Vector2(xcir, zcir) + i);
        }
        Vector3 move = new Vector3(xcir, 0, zcir);
        move.y = 0f;
        transform.position = move;
    }
}
