using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public int HP;
    public int DAMAGE;
    public float SPEED;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position + GetComponent<SphereCollider>().center, GetComponent<SphereCollider>().radius);
    }
}