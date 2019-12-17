using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class Boll : MonoBehaviour
{

    //public bool playeralive;     -ta inte bort

    [SerializeField]
    Rigidbody rb;

    [SerializeField]
    GameObject coinObject = null;

    void Start()
    {
        //playeralive = true;
        rb.GetComponent<Rigidbody>();  //hämtar rigidbody.
    }

    void Update()
    {
        //if (playeralive)         -ta inte bort
        {
           

            if (Input.GetKey(KeyCode.D))
            {
                rb.velocity = new Vector3(rb.velocity.x, 0, 15);
            }
            if (Input.GetKey(KeyCode.A))
            {
                rb.velocity = new Vector3(rb.velocity.x, 0, -15);
            }
            if (Input.GetKey(KeyCode.S))
            {
                rb.velocity = new Vector3(15, 0, rb.velocity.z);
            }
            if (Input.GetKey(KeyCode.W))
            {
                rb.velocity = new Vector3(-15, 0, rb.velocity.z);
            }
            //Står för bollens rörelseförmåga. (gabriel)
        }


        /*if(!playeralive)              -ta inte bort
        {

        }
        */
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "coin")
        {
            Destroy(other.gameObject);
            Coin.points ++;
        }

        if (other.transform.tag == "Death")
        {
            SceneManager.LoadScene("Startmeny", LoadSceneMode.Single);
            //playeralive = false;             -ta inte bort
            Coin.points = 0;
        }
        /*
    * Förkalrar för datorn att det är dags att starta om spelet vid startmenyn vid death
    * Visar att det ska lägga till ++ = 1 vid collision av coin. Gabbe
    */
    }
}