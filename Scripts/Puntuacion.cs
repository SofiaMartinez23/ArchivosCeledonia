using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntuacion : MonoBehaviour
{
    private float puntos;
    private TextMeshProUGUI textMesh;

    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        puntos = PlayerPrefs.GetFloat("PlayerPoints", 0);
        textMesh.text = puntos.ToString("0");

    }

    // Update is called once per frame
    void Update()
    {
        //puntos += Time.deltaTime;
        textMesh.text = puntos.ToString("0");
       
    }

    public void SumarPuntos(float puntosEntrada)
    {
        puntos += puntosEntrada;
        PlayerPrefs.SetFloat("PlayerPoints", puntos);
        PlayerPrefs.Save();

    }
   
}
