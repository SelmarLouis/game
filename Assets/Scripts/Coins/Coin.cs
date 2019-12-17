using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    [SerializeField]
    Text coinCounter;
    [SerializeField]
    Text highScoreText;

    Text text;
    public static int points;
    void Start()
    {
       
        
    }

    private void Update()
    {
        coinCounter.text = "Coins collected: " + points.ToString();
    }
}
