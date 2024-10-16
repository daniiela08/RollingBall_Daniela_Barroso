using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAMBIOCAM3 : MonoBehaviour
{

    [SerializeField] private GameObject Camarapersonaje;
    [SerializeField] private GameObject CAMARA2TOBOGAN;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PLAYER"))
        {
            if (Camarapersonaje.activeSelf)
            {
                Camarapersonaje.SetActive(false);
                CAMARA2TOBOGAN.SetActive(true);
            }
            else
            {
                Camarapersonaje.SetActive(true);
                CAMARA2TOBOGAN.SetActive(false);

            }
        }

    }
}
