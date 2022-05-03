using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboardDetectTest : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    //private bool held = false;
    //private float time = 0.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space)) {
            rb.velocity += new Vector3(0, 0, -1);
        }
        /*
        while (Input.GetKey("up")) {
            time = time + Time.fixedDeltaTime;
            held = true;
        }
        if (held == true) {
            rb.velocity = new Vector3(0, 0, (time/1.3));
            time = 0;
            held = false;
        }
        //
        */
    }
}
