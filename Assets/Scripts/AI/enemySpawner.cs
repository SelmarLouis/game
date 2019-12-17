using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    [SerializeField]
    public float elapsedTime = 0.0f;
    [SerializeField]
    public float timeLimit = 10.0f;
    [SerializeField]
    Rigidbody enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if(elapsedTime > timeLimit)
        {
            Vector3 position = new Vector3(Random.Range(-47.5f, 47.5f), 1, Random.Range(-80, 85));
            Instantiate(enemy, position, Quaternion.identity);
            elapsedTime = 0;
        }
    }
}
