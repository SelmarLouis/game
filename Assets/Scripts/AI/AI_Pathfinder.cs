using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI_Pathfinder : MonoBehaviour
{
   
    [SerializeField]
    GameObject target; //(Gabriel) Säger till att gameobject heter target.

    NavMeshAgent agent;//(Gabriel) säger till att man ska använda unitys navmeshagent.

    void Start()
    {
        agent = GetComponent<NavMeshAgent>(); //(Gabriel) Hämtar Navmeshagent
    }


    void Update()
    {
        agent.SetDestination(target.transform.position);//(Gabriel) bestämmer position den ska till
    }

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