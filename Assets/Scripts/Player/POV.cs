using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POV : MonoBehaviour
{
    [SerializeField]
    Transform player; //Sätter positionen på kameran på "spelaren".
    Vector3 offset; //säger till vilket avstånd det ska vara med en 3D vector.
    void Start()
    {
        offset = transform.position - player.position; //position på cameran
    }


    void Update()
    {
        transform.position = player.position + offset; //flyttar kameran genom hela tiden som det körs.
    }
}
