using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FBenemy : MonoBehaviour
{
    public float speed;
    public Transform[] moveSpots;
    private int randomSpot;
    private float waitTime = 0;
    public float startWaitTime = 0.2f;
    private void Start()
    {
        waitTime = startWaitTime;
        randomSpot = Random.Range(0, moveSpots.Length);
    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, moveSpots[randomSpot].position, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, moveSpots[randomSpot].position) < 0.2f)
        {
            if (waitTime <= 0)
            {
                randomSpot = Random.Range(0, moveSpots.Length);
                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
    }
}
// Allt gjordes av David och Oscar men kom inte med i slutprodukten