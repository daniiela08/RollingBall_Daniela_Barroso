using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionObjetos : MonoBehaviour
{
    [SerializeField] Vector3 direccR;
    [SerializeField] int fuerza;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddTorque(direccR * fuerza, ForceMode.VelocityChange);
    }

    
    void Update()
    {
     
    }
}
