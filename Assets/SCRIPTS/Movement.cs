using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    public float fuerza;
    void Start()
    {
        rb = GetComponent < Rigidbody >();
    }

    void FixedUpdate()
    {
        float movX = Input.GetAxis("Horizontal");
        float movZ = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movX, 0, movZ);

        rb.AddForce(movimiento * fuerza);
    }
    void Update()
    {
        
    }
}
