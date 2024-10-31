using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RecuperarTime : MonoBehaviour
{
    [SerializeField] TMP_Text tiempo;
    private int minutos;
    private float segundos;
    void Start()
    {
        
    }
    void Update()
    {
        minutos = PlayerPrefs.GetInt("PuntuacionMin");
        segundos = PlayerPrefs.GetInt("PuntuacionSeg");
        tiempo.text = minutos.ToString("00") + ":" + segundos.ToString("00");
    }
}
