using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayeControl : MonoBehaviour
{
    Rigidbody rb;
    private float Speed = 0.15f;
    private float moveX;
   
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal") * Speed;
        rb.AddForce(transform.right * moveX, ForceMode.Impulse);
    }
    public void MaterialA()
    {
        GetComponent<Renderer>().material.color = Color.red;

    }
    public void MaterialB()
    {
        GetComponent<Renderer>().material.color = Color.blue;
    }
}
