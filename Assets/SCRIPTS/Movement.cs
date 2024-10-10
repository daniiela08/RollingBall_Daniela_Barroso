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
    [SerializeField] TMP_Text textoVidas;
    private int puntos;
    private int vida;

    Vector3 posicionInicio;
    void Start()
    {
        rb = GetComponent < Rigidbody >();
        puntos = 0;
        vida = 3;
        textoPuntos.text = ("Monedas :0");
        textoVidas.text = ("vidas 0");
        posicionInicio = transform.position;
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
        if (other.gameObject.CompareTag("trampa"))
        {
            vida--;
            textoVidas.text = "vidas " + vida;
        }
        if (other.gameObject.CompareTag("puerta") && puntos == 7)
        {
            Destroy(other.gameObject);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("vacio"))
        {
            transform.position = posicionInicio;
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
      
    }

}
