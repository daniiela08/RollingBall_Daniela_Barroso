using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float fuerzasalto;
    private Rigidbody rb;
    public float fuerza;
    Vector3 salto;
    Vector3 movimiento;
    [SerializeField] TMP_Text textoPuntos;
    private int puntos;
    
    void Start()
    {
        rb = GetComponent < Rigidbody >();
        puntos = 0;
        textoPuntos.text = ("x 0");
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
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("item"))
        {
            Destroy(other.gameObject);
            puntos++;
            textoPuntos.text = "Monedas" + puntos.ToString(" :0");
        }
    }

}
