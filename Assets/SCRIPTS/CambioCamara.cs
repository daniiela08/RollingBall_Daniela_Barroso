using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioCamara : MonoBehaviour
{
    [SerializeField] private GameObject Camarapersonaje;
    [SerializeField] private GameObject Camaraembudo;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PLAYER"))
        {
            if(Camarapersonaje.activeSelf)
            {
                Camarapersonaje.SetActive(false);
                Camaraembudo.SetActive(true);
            }
            else
            {
                Camarapersonaje.SetActive(true);
                Camaraembudo.SetActive(false);
                   
            }
        }

    }
}
