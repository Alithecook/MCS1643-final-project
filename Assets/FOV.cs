using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOV : MonoBehaviour

{
    private GameObject player;
    private bool hasLineOfSight = false;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {//maybe get rid of dashes below for the line of sight thing
        //if (hasLineOfSight)
        //{
            //possibly put gameover screen thing here
        //}
    }
    private void FixedUpdate()
    {
        if (hasLineOfSight) 
        {
            RaycastHit2D ray = Physics2D.Raycast(transform.position, player.transform.position - transform.position);
            if(ray.collider != null)
            {
                hasLineOfSight = ray.collider.CompareTag("Player");
                if(hasLineOfSight)
                {
                    Debug.DrawRay(transform.position, player.transform.position - transform.position, Color.green);
                }
                else
                {
                    Debug.DrawRay(transform.position, player.transform.position - transform.position, Color.red);
                }
            }
        }
    }
}
