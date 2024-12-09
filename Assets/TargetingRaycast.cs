using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetingRaycast : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        bool result = Physics.Raycast(
            transform.position, 
            transform.forward, 
            out hit,
            20.0f
            );
        Debug.Log($"Am I seeing something? {result}");
    }
}
