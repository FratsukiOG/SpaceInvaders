using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public GameObject menu;
    public GameObject menuControl;
    public GameObject pauseMenu;
    public GameObject gameOver;


    bool bandera;
    public void ChangeMenuState()
    {
        bandera = !bandera;
        menu.SetActive(bandera);



        print("Menu Activo");

    }

    public void ChangeMenuControlState()
    {
        bandera = !bandera;
        menuControl.SetActive(bandera);


        print("Menu de controles Activo");
    }

    public void PauseMenu()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            bandera = !bandera;
            pauseMenu.SetActive(bandera);


            print("Pausa Activo");
        }
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(0);
    }

}
