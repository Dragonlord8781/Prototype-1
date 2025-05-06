using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f; // speed
    private float turnSpeed = 45.0f; //turnspeed
    private float horizontalInput; // input 1 (horizontal)
    private float forwardInput; // input 2 (verticle/foward&backwards)

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //connects horizonatlInput to the Axis input horizontal
        horizontalInput = Input.GetAxis("Horizontal"); 
        //connects forwardInput to the Axis input Vertical
        forwardInput = Input.GetAxis("Vertical");

        //moves vehicle forward/backward based on speed & fowardInput
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //rotates vehicle based on horizontal input & turnspeed
        transform.Rotate(Vector3.up, horizontalInput * turnSpeed * Time.deltaTime);
    }
}
