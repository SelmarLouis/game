using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    [SerializeField]
    Text coinCounter;
    [SerializeField]
    public float elapsedTime = 0.0f;
    [SerializeField]
    public float pointTimer = 20.0f;
    [SerializeField]
    public float pointCounter = 0;
    [SerializeField]
    public float pointAdd = 5;
    [SerializeField]
    Text highScoreText;

    public static int points;

    void Start()
    {
      
    }

    private void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > pointTimer)
        {
            pointCounter += pointAdd;
            elapsedTime = 0;
        }
            coinCounter.text = "Coins: " + points.ToString();

    }
}
