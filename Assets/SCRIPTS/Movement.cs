using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    private float tiempoTotal = 300f;
    private float tiempoRestante;
    [SerializeField] TMP_Text crono;
    private int segundos;
    private int minutos;

    [SerializeField] private float radioRay;

    Vector3 posicionInicio;

    private AudioSource audio;

    void Start()
    {
        rb = GetComponent < Rigidbody >();
        puntos = 0;
        vida = 3;
        textoPuntos.text = ("Monedas :0");
        textoVidas.text = ("vidas: 3");
        posicionInicio = transform.position;
        tiempoRestante = tiempoTotal;
        audio = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        float movX = Input.GetAxis("Horizontal");
        float movZ = Input.GetAxis("Vertical");
        if (Input.GetKeyDown(KeyCode.Space)&&tocoSuelo())
        {
            salto = new Vector3(0, 1, 0);
            rb.AddForce(salto * fuerzasalto, ForceMode.Impulse);
        }
         movimiento = new Vector3(movX, 0, movZ);

        tiempoRestante -= Time.deltaTime;

         minutos = Mathf.FloorToInt(tiempoRestante / 60);
         segundos = Mathf.FloorToInt(tiempoRestante % 60);

        crono.text = minutos.ToString("00") + ":" + segundos.ToString("00");
        if(tiempoRestante <= 0)
        {
            SceneManager.LoadScene(3);
        }
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
            audio.Play();
        }
        if (other.gameObject.CompareTag("VAIO2"))
        {
            transform.position = posicionInicio;
        }


    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("vacio"))
        {
            transform.position = posicionInicio;
        }
        
    }
    private void OnCollisionStay(Collision collision)
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("trampa"))
        {
            vida--;
            textoVidas.text = "vidas " + vida;
            if (vida == 0)
            {
                SceneManager.LoadScene ("muerte");
            }
        }
        if (collision.gameObject.CompareTag("puerta") && puntos >= 5)
        {
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.CompareTag("ganar"))
        {
            PlayerPrefs.SetInt("PuntuacionMin", minutos);
            PlayerPrefs.SetInt("PuntuacionSeg", segundos);
            SceneManager.LoadScene(4);
        }
    }
    private bool tocoSuelo()
    {
        bool resultado = Physics.Raycast(transform.position, Vector3.down, radioRay);
        Debug.DrawLine(transform.position, Vector3.down, Color.red, 2f);
        return resultado;
    }
}
