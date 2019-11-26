using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boll : MonoBehaviour
{
    [SerializeField]
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(new Vector3(0, 0, 500));
            rb.velocity = Vector3.zero;
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(new Vector3(0, 0, -500));
            rb.velocity = Vector3.zero;
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector3(500, 0, 0));
            rb.velocity = Vector3.zero;

        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector3(-5000, 0, 0));
            rb.velocity = Vector3.zero;


        }

    }
}