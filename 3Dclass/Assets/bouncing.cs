using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouncing : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody rb;
    public Vector3 force;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        print("QQ");
        
        if (collision.collider.tag==("888"))
        {
            rb.AddForce(force);
        }
    }
}
