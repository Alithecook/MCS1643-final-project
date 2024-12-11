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
        RaycastHit2D hit = Physics2D.Raycast(
            transform.position, 
            transform.forward,
            20.0f
            );
        if (hit != null) {
         Debug.Log($"seeing something {hit.collider.gameObject.transform.name}");
        } else {
            Debug.Log("Not seeing anything");
        }
    }
}
