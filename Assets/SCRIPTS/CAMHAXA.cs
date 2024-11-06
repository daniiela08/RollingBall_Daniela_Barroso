using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAMHAXA : MonoBehaviour
{
    [SerializeField] private GameObject Camarapersonaje;
    [SerializeField] private GameObject HACHACAM;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("PLAYER"))
        {
            if (Camarapersonaje.activeSelf)
            {
                Camarapersonaje.SetActive(false);
                HACHACAM.SetActive(true);   
            }
            else
            {
                Camarapersonaje.SetActive(true);
                HACHACAM.SetActive(false);
            }
        }
    }
}
