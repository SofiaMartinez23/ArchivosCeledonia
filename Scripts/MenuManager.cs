using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    
    public void Button_Inicio()
    {
        SceneManager.LoadScene("pueblo1"); 
    }

   
    public void Button_Salir()
    {
        Debug.Log("Quitamos la aplicacion");
        Application.Quit();
    }
}
