using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Moover : MonoBehaviour
{
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        float scalex = transform.localScale.x * 10;
        float scalez = transform.localScale.z * 10;
        for (int i = 0; i <= scalex; i++)
        {
            Gizmos.DrawLine(new Vector3(-scalex / 2 + i, 0.001f, scalez / 2), new Vector3(-scalex / 2 + i, 0.001f, -scalez / 2));
        }
        for (int i = 0; i <= scalez; i++)
        {
            Gizmos.DrawLine(new Vector3(-scalex / 2, 0.001f, (scalez / 2) - i), new Vector3(scalex / 2, 0.001f, (scalez / 2) - i));
        }
    }
}
