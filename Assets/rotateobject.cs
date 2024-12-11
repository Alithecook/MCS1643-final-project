using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateobject : MonoBehaviour
{
    public float rotZ;
    public float RotationSpeed;
    public bool ClockwiseRoataion;
  
    // Update is called once per frame
    void Update()
    {
        if(ClockwiseRoataion==false)
        {
            rotZ += Time.deltaTime * RotationSpeed;
        }
        else
        {
            rotZ += -Time.deltaTime * RotationSpeed;
        }
        transform.rotation = Quaternion.Euler(0, 0, rotZ);
    }
}
