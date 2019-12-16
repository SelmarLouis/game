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

            elapsedTime = 0;
        }
        pointCounter.text = "Coins earned:" + pointSum.ToString();
    }
}
