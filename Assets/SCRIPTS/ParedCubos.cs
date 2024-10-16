using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParedCubos : MonoBehaviour
{
    private bool iniciarTimer;
    private float timer = 0;
    void Start()
    {
        
    }

   
    void Update()
    {
        if(iniciarTimer)
        {
            Time.timeScale = timer;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PLAYER"))
        {

        }
    }
}
