using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaCae : MonoBehaviour
{
    private bool iniciarTimer;
    private float timer = 0;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (iniciarTimer)
        {
            timer += Time.unscaledDeltaTime;
            if (timer >= 1f)
            {
                rb.isKinematic = false;
            }
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("PLAYER"))
        {
            iniciarTimer = true;
        }
    }
}
