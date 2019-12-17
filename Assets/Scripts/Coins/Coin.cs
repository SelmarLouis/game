using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    [SerializeField]
    Text coinCounter;
    Text text; //Variable för Text.(Gabriel)

    public static float points; //Variabel för poäng (Gabriel)
    private void Update()
    {
        coinCounter.text = "Points earned: " + points.ToString("F0"); //skriver ut poängen (Gabriel)
        points += Time.deltaTime / 2; // förklarar att efter varannan frame så lägg till 1(Gabriel)
    }
}
