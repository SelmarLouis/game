﻿using System.Collections;
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
    public static float points;
    void Start()
    {
       
        
    }

    private void Update()
    {
        coinCounter.text = "points earned: " + points.ToString("F0");
        points += Time.deltaTime / 2;
    }
}
