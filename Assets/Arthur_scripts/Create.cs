using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Create : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public GameObject tower;
    public bool flag = true;
    public void OnBeginDrag(PointerEventData eventData)
    {
        Instantiate(this.gameObject, transform.position, Quaternion.identity);
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (flag)
        {
            Instantiate(tower, eventData.pointerCurrentRaycast.worldPosition, Quaternion.identity);
            flag = false;
        }
        print("SPOK");
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
        Instantiate(tower, /*eventData.pointerCurrentRaycast.worldPosition*/ new Vector3(xcir, pos.y, zcir), Quaternion.identity);
        print("Tower is build");
    }
}
