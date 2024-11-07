using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraReinicio : MonoBehaviour
{
    [SerializeField] private GameObject Camarapersonaje;
    [SerializeField] private GameObject HACHACAM;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PLAYER"))
        {

            HACHACAM.SetActive(false);
            Camarapersonaje.SetActive(true);
        }
    }
}
