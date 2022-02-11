using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Path : MonoBehaviour
{
    public GameObject target;
    NavMeshAgent gg;
    void Start()
    {
        gg = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        gg.SetDestination(target.transform.position);
    }
}
