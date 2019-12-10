using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatingwall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, Time.deltaTime * 30, 0)); // För att få väggen att Rotera sig (Oscar).
    }
}
