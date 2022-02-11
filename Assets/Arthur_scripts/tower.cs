using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class tower : MonoBehaviour
{
    private GameObject current_enemy;
    public int HP;
    public int DAMAGE;
    public int RELOAD;
    private float last_shoot_time;
    public Transform head;

    private void Update()
        {
        if (current_enemy != null)
        {
            Quaternion targetRotation = Quaternion.LookRotation(current_enemy.transform.position - head.transform.position);
            head.transform.rotation = targetRotation;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        print('1');
        if (other.gameObject == current_enemy)
        {
            if (Time.time - last_shoot_time < RELOAD)
            {
                return;
            }
            current_enemy.GetComponent<enemy>().HP -= DAMAGE;
            last_shoot_time = Time.time;
        }
        if (current_enemy != null)
        {
            if (current_enemy.GetComponent<enemy>().HP <= 0)
            {
                Destroy(current_enemy);
                current_enemy = null;
            }
        }
        if (other.tag == "enemy")
        {
            print('2');
            if (current_enemy == null)
            {
                current_enemy = other.gameObject;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == current_enemy)
        {
            current_enemy = null;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position + GetComponent<SphereCollider>().center, GetComponent<SphereCollider>().radius);
    }
}