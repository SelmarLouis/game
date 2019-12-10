﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Boll : MonoBehaviour
{
    [SerializeField]
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody>(); //Selmar was here
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector3(rb.velocity.x, 0, 5);
            //rb.AddForce(new Vector3(0, 0, 25));
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector3(rb.velocity.x, 0, -5);
            //rb.AddForce(new Vector3(0, 0, -25));
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector3(5, 0, rb.velocity.z);
            //rb.AddForce(new Vector3(25, 0, 0));

        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector3(-5, 0, rb.velocity.z);
            //rb.AddForce(new Vector3(-250, 0, 0));
        }



    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Death")
        {
            SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        }
    }
}