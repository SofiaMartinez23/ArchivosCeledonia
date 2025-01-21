using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScenas : MonoBehaviour
{
    
   public void BotonesGameMenu(string escena)
    {
        SceneManager.LoadScene(escena);
    }

    public void OnDisable() 
    {
        Time.timeScale = 1.0f;
    }

    public void OnEnable()
    {
        Time.timeScale = 0f;
    }


}
