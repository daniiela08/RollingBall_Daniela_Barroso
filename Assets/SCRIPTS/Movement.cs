using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float fuerzasalto;
    private Rigidbody rb;
    public float fuerza;
    Vector3 salto;
    Vector3 movimiento;
    void Start()
    {
        rb = GetComponent < Rigidbody >();
    }

    
    void Update()
    {
        float movX = Input.GetAxis("Horizontal");
        float movZ = Input.GetAxis("Vertical");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            salto = new Vector3(0, 1, 0);
            rb.AddForce(salto * fuerzasalto, ForceMode.Impulse);
        }
         movimiento = new Vector3(movX, 0, movZ);
    }
    void FixedUpdate()
    {





        rb.AddForce(movimiento * fuerza);
        //rb.velocity += new Vector3(0, -9.81f * 4, 0);
    }
}
