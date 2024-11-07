using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camarabase : MonoBehaviour
{
    [SerializeField] private GameObject Camarapersonaje;
    [SerializeField] private GameObject HACHACAM;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PLAYER"))
        {
            if (HACHACAM.activeSelf)
            {
                HACHACAM.SetActive(false);
                Camarapersonaje.SetActive(true);
            }
        }
    }
}
