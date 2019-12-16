using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBill : MonoBehaviour
{
    [SerializeField]
    Rigidbody Bulletbill;

    void Start()
    {
        Bulletbill = GetComponent<Rigidbody>();
    }

   
    void Update()
    {
        Bulletbill.velocity = new Vector3(5, 0, 0);
    }
}
