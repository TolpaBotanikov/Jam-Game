using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Moover : MonoBehaviour, IDragHandler
{
    public GameObject mesh;
    public void OnDrag(PointerEventData eventData)
    {
        Instantiate(mesh, eventData.pointerCurrentRaycast.worldPosition, Quaternion.identity);
        print(eventData.pointerCurrentRaycast.worldPosition);
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        for (int i = 0; i <= 25; i++)
        {
            Gizmos.DrawLine(new Vector3(-12.5f + i, 0.001f, 25), new Vector3(-12.5f + i, 0.001f, -25));
        }
        for (int i = 0; i <= 50; i++)
        {
            Gizmos.DrawLine(new Vector3(-12.5f, 0.001f, 25 - i), new Vector3(12.5f, 0.001f, 25 - i));
        }
    }
}
