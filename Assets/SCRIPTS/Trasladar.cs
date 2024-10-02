using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trasladar : MonoBehaviour
{
    [SerializeField] Vector3 direccion;
    [SerializeField] int velocidad;
    float timer = 0;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(direccion * velocidad * Time.deltaTime);  
        timer=timer+Time.deltaTime;

        if (timer >= 10f)
        {
            direccion=-direccion;
            timer = 0f;
        }
    }
}
