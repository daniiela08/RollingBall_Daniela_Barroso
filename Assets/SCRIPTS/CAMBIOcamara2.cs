using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAMBIOcamara2 : MonoBehaviour
{

    [SerializeField] private GameObject Camarapersonaje;
    [SerializeField] private GameObject CAMARATOBOGAN;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PLAYER"))
        {
            if (Camarapersonaje.activeSelf)
            {
                Camarapersonaje.SetActive(false);
                CAMARATOBOGAN.SetActive(true);
            }
            else
            {
                Camarapersonaje.SetActive(true);
                CAMARATOBOGAN.SetActive(false);

            }
        }

    }
}
