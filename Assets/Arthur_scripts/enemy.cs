using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public int HP;
    public int DAMAGE;
    public float SPEED;

    public void Damage(int damage)
    {
        HP -= damage;
    }
}
