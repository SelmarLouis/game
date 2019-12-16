using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pointcounter : MonoBehaviour
{
    [SerializeField]
    Text coinCounter;
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
    public static int points;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > pointTimer)
        {
            
            pointSum += pointAdd;
            elapsedTime = 0;
            pointSum += points;
        }
       
        coinCounter.text = "Points Earned: " + pointSum.ToString();
       
    }
}
