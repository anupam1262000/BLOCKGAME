using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movements : MonoBehaviour
{

    public Rigidbody rb;

    // Update is called once per frame
    void Update()
    {

       /* if (Input.touchCount == 1) {
            rb.AddForce(0, 0, Time.deltaTime * 1000);
        }
        else if (Input.touchCount == 2)
        {
            rb.AddForce(-1 * 1000 * Time.deltaTime, 0, 0);
        }
        else if (Input.touchCount == 3)
        {
            rb.AddForce(1 * 1000 * Time.deltaTime,0,0);
        }
        else if (Input.touchCount == 4)
        {
            rb.AddForce(0,0,-1500 * Time.deltaTime);
        }
        */        
          if (Input.GetKey("w"))
             rb.AddForce(0, 0, 1000 * Time.deltaTime);
         if (Input.GetKey("a"))
             rb.AddForce(-1*1000 * Time.deltaTime,0,0);
         if (Input.GetKey("s"))
             rb.AddForce(0, 0, -1*1000 * Time.deltaTime);
         if (Input.GetKey("d"))
             rb.AddForce(1000 * Time.deltaTime,0,0);
         if (Input.GetKey(KeyCode.Space))
             rb.AddForce(0,1500 * Time.deltaTime, 0);  

    }
}

