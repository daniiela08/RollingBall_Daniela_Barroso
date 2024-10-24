using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rampacamara : MonoBehaviour
{
    [SerializeField] private GameObject Camarapersonaje;
    [SerializeField] private GameObject Rampa;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PLAYER"))
        {
            if (Camarapersonaje.activeSelf)
            {
                Camarapersonaje.SetActive(false);
                Rampa.SetActive(true);
            }
            else
            {
                Camarapersonaje.SetActive(true);
                Rampa.SetActive(false);

            }
        }

    }
}
