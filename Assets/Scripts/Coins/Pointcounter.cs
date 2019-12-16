using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pointcounter : MonoBehaviour
{
    [SerializeField]
    Text pointCounter;
    [SerializeField]
    public float elapsedTime = 0.0f;
    [SerializeField]
    public float pointTimer = 20.0f;
    [SerializeField]
    public float pointCounter1 = 0;
    [SerializeField]
    public float pointAdd = 5;
    [SerializeField]
    public float pointSum = 0;
    public float points;
    void Start()
    {
        
    }
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > pointTimer)
        {
            
            pointSum += pointAdd;
            elapsedTime = 0;
           
        }

        pointCounter.text = "Points Earned: " + pointSum.ToString();

    }
  /* private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "coin")
        {
            points++;
        }
        
    }*/
}
