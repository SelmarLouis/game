using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomgenerator_Coin : MonoBehaviour
{
    public Transform Coin;
    //public GameObject Coin;
    [SerializeField]
    public float elapsedTime = 0.0f;
    [SerializeField]
    public float secondsBetweenSpawn = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > secondsBetweenSpawn)//if sats för att skapa mina rör.
        {

            Vector3 position = new Vector3(Random.Range(-47.5f, 47.5f), 1, Random.Range(-80, 85));
            Instantiate(Coin, position, Quaternion.identity);
            elapsedTime = 0;
        }
    }
  
}
