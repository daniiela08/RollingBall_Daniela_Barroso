using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionItem : MonoBehaviour
{
    [SerializeField] Vector3 direccR;
    [SerializeField] Vector3 direccT;
    [SerializeField] int velocR;
    [SerializeField] float velocT;
    float timer = 0f;
    void Start()
    {
        
    }

   
    void Update()
    {
     transform.Rotate(direccR*velocR*Time.deltaTime, Space.World);   
     transform.Translate(direccT*velocT*Time.deltaTime, Space.World);
        timer =timer +Time.deltaTime;

        if (timer > 2f)
        {
            direccT = -direccT;
            timer = 0f;
        }
    }
}
