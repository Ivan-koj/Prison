using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class npcAI : MonoBehaviour
{
    public GameObject theDestination;

    private NavMeshAgent thAgent;
    // Start is called before the first frame update
    void Start()
    {
        thAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        thAgent.SetDestination(theDestination.transform.position);
    }
}
