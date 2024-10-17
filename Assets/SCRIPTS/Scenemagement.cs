using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scenemagement : MonoBehaviour
{
    public void Juego()
    {
        SceneManager.LoadScene("JUEGO");
    }
    public void Salir()
    {
        Debug.Log("Adios");
    }
    public void gameover()
    {
        SceneManager.LoadScene("JUEGO");
    }
    public void objetivo()
    {
        SceneManager.LoadScene("MENU");
    }
    public void OBJETIVE()
    {
        SceneManager.LoadScene("OBJETIVO");
    }
}
