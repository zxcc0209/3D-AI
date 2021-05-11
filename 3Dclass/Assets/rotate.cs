using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public Vector3 AA;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Translate
        if (Input.GetKey("right"))
        {
            transform.Translate(0.1f, 0, 0);
        }
        if (Input.GetKey("left"))
        {
            transform.Translate(-0.1f, 0, 0);
        }
        if (Input.GetKey("up"))
        {
            transform.Translate(0, 0, 0.1f);
        }
        if (Input.GetKey("down"))
        {
            transform.Translate(0, 0, -0.1f);
        }



        //Rotate
        if (Input.GetKey("a"))
        {
            transform.Rotate(0, 0, 2);
        }
        if (Input.GetKey("d"))
        {
            transform.Rotate(0, 0, -2);
        }
        if (Input.GetKey("w"))
        {
            transform.Rotate(2, 0, 0);
        }
        if (Input.GetKey("s"))
        {
            transform.Rotate(-2, 0, 0);
        }
    }

}
