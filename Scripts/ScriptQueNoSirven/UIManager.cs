using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private int totalMonedas;
    public int TotalObjetos;
    private int precioObjetos;

    [SerializeField] private TMP_Text textoMonedas;
    [SerializeField] private List<GameObject> listaCorazones;
    [SerializeField] private Sprite corazonDesactivado, corazonActivado;

    [SerializeField] private GameObject panelEquipo;

    private void Start()
    {
        Moneda.sumaMoneda += SumarMonedas;
    }

    private void SumarMonedas(int moneda)
    {
        totalMonedas += moneda;
        textoMonedas.text = totalMonedas.ToString();
    }

    public void RestaCorazones (int indice)
    {
        Image imagenCorazon = listaCorazones[indice].GetComponent<Image>();
        imagenCorazon.sprite = corazonDesactivado;
    }

    public void SumaCorazones(int indice)
    {
        Image imagenCorazon = listaCorazones[indice].GetComponent<Image>();
        imagenCorazon.sprite = corazonActivado;
    }


    #region Tienda

    public void PrecioObjeto (string objeto)
    {
        switch(objeto)
        {
            case "ButtonPocionPequeña":
                precioObjetos = 1; 
                break;

            case "ButtonPocionGrande":
                precioObjetos = 2;
                break;

            case "ButtonPocionVel":
                precioObjetos = 3;
                break;
        }
    }


    public void AdquirirObjeto (string objeto)
    {
        PrecioObjeto(objeto);

        if (precioObjetos <= totalMonedas && TotalObjetos < 3)
        {
            TotalObjetos++;
            totalMonedas -= precioObjetos;
            textoMonedas.text = totalMonedas.ToString();

            GameObject equipo = (GameObject)Resources.Load(objeto);
            Instantiate(equipo, Vector3.zero, Quaternion.identity, panelEquipo.transform);

        }

    }


    #endregion
}
