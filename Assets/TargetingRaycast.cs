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
       bool result = Physics.Raycast(transform.position, transform.forward);
       Debug.Log($"Am I seeing something? {result}");
    }
}
