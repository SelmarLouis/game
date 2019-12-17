using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour
{
    public Text highscoretext;
    float HS;
    

    // Start is called before the first frame update
    void Start()
    {
        HS = PlayerPrefs.GetFloat("Highscore");
    }

    // Update is called once per frame
    void Update()
    {
        if (Coin.points > HS)
        {
            HS = Coin.points;
            PlayerPrefs.SetFloat("Highscore", HS);
            highscoretext.text = HS.ToString();
        }
    }
}
