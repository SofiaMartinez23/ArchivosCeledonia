using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorPuntos : MonoBehaviour
{

    public static ControladorPuntos Instance;

    [SerializeField] private float cantidadPuntos = 0;

    void Start()
    {
        cantidadPuntos = PlayerPrefs.GetFloat("PlayerPoints", 0);
    }
    void Awake()
    {
        if (ControladorPuntos.Instance == null)
        {
            ControladorPuntos.Instance = this;
            DontDestroyOnLoad(this.gameObject);
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SumarPuntos(float puntos)
    {
        cantidadPuntos += puntos;
        PlayerPrefs.SetFloat("PlayerPoints", cantidadPuntos);
        PlayerPrefs.Save();
    }

    public void ReiniciarPuntuacion()
    {
        cantidadPuntos = 0;
        PlayerPrefs.SetFloat("PlayerPoints", cantidadPuntos);
        PlayerPrefs.Save();
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Suponiendo que el nivel 1 es la primera escena (índice 0)
        if (scene.buildIndex == 3)
        {
            ReiniciarPuntuacion();
        }
    }

}
