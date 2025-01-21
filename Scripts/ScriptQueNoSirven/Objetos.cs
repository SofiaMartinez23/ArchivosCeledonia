using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Objetos;

public class Objetos : MonoBehaviour
{
    public enum ObjetosEquipo {

        SaludPeque,
        SaludGrande,
        Velocidad
    };

    [SerializeField] ObjetosEquipo objetosEquipo;

    public void UsarObjeto()
    {
        Player personaje = GameObject.FindObjectOfType<Player>();
        UIManager uiManager = GameObject.FindObjectOfType<UIManager>();


        switch (objetosEquipo)
        {
            case ObjetosEquipo.SaludPeque:
                if (personaje.vidaPersonaje < 3)
                {
                    personaje.SumaVida();
                    Destroy(this.gameObject);
                }
                break;
            case ObjetosEquipo.SaludGrande:
                Debug.Log("Cura dos puntos de Salud");
                break;
            case ObjetosEquipo.Velocidad:
                Debug.Log("Concede Velocidad");
                Destroy(this.gameObject);
                break;

        }
        uiManager.TotalObjetos--;
    }
}