using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Randomgenerator_Coin : MonoBehaviour
{

    public Transform Coin;
    [SerializeField]
    public float elapsedTime = 0.0f;//Variabel för tid som den börjar med och hur mycket som gått. (Gabriel)
    [SerializeField]
    public float secondsBetweenSpawn = 5.0f; //Variable för att begränsa tiden.(gabriel)
    void Update()
    {
        elapsedTime += Time.deltaTime;//Tiden som går mellan två frames(Gaberiel)
        if (elapsedTime > secondsBetweenSpawn)//if sats för att skapa mina rör.(gabriel)
        {

            Vector3 position = new Vector3(Random.Range(-47.5f, 47.5f), 1, Random.Range(-80, 85));// Förklarar mellan vilka punkter som ett object ska skapa (Gabriel)
            Instantiate(Coin, position, Quaternion.identity);//skapar object. (gabriel)
            elapsedTime = 0;//refreshar tiden till 0 (Gabriel)
        }
      
    }
  
}
