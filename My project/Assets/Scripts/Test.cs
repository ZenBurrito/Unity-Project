using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //Destroy(gameObject,3f);

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Destroy(gameObject);

            //If space bar is pressed, cube jumps 500 u
            rb.AddForce(Vector3.up * 225);
        }
        //Moves cube forward 20 every frame
        if(Input.GetKeyDown(KeyCode.D))
        { 
            rb.velocity = Vector3.right * 4;
        }
        //rb.velocity = Vector3.forward * 20f;
        if(Input.GetKeyDown(KeyCode.W))
        { 
            rb.velocity = Vector3.forward * 4;
        }
        if(Input.GetKeyDown(KeyCode.A))
        { 
            rb.velocity = Vector3.left * 4;
        }
        if(Input.GetKeyDown(KeyCode.S))
        { 
            rb.velocity = Vector3.back * 4;
        }
    }


    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
