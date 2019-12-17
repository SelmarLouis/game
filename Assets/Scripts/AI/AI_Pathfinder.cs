using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI_Pathfinder : MonoBehaviour
{
   
    [SerializeField]
    GameObject target;

    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        agent.SetDestination(target.transform.position);
    }

    /*(SELMAR) När spelaren kolliderar med agent:ens sphere collider kollar agent:en om det är ett objekt med 
    tag:en "Player" som har kolliderat med den. Ifall det var en spelare så förföljer agent:en spelaren genom Update metoden ovan. 
    Så fort spelaren lämnar agent:ens Sphere collider radius blir agentens target till sig själv igen och den slutar följa seplaren.
    Denna kod gör att agent:en inte jagar spelaren i all oändlighet utan bara om spelaren kolliderar med agent:ens sphere collider.
    Det ska funka ungefär som en search-radius för motståndaren.*/

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            target = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            target = gameObject;
        }
    }
}