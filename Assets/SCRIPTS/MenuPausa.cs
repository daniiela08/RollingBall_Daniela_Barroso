using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    [SerializeField] Canvas menu;
    private bool pause;
    void Start()
    {
        menu.gameObject.SetActive(false);
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
            pause = !pause;
            menu.gameObject.SetActive(pause);
            if (pause == true)
            {
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
            }
        }
    }
    public void continuar()
    {
        menu.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
    public void salir()
    {
        SceneManager.LoadScene(0);
    }
}
