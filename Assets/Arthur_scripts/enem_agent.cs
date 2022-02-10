using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enem_agent : MonoBehaviour
{
    public GameObject target;
    private NavMeshAgent main;
    // Start is called before the first frame update
    void Start()
    {
        main = GetComponent<NavMeshAgent>();
        Destroy(GameObject.Find("Cube (1)"));
        Destroy(GameObject.Find("Cube (2)"));
    }

    // Update is called once per frame
    void Update()
    {
        main.SetDestination(target.transform.position);
    }
}
