using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Create : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public GameObject tower;
    public bool flag = true;
    public static List<Vector2> placeActive = new List<Vector2>();
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
        foreach(Vector2 i in tower.GetComponent<Tyrel>().coor)
        {
            if (placeActive.Contains((new Vector2(xcir, zcir) + i)))
            {
                return;
            }
        }
        placeActive.Add(new Vector2(xcir, zcir));
        foreach (Vector2 i in tower.GetComponent<Tyrel>().coor)
        {
            placeActive.Add(new Vector2(xcir, zcir) + i);
        }
        placeActive.Add(new Vector2(xcir, zcir));
        Instantiate(tower, new Vector3(xcir, pos.y, zcir), Quaternion.identity);
        print("Tower is build");
    }
}
