using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class FruitColecter : MonoBehaviour
{
    [SerializeField] private float cantidadPuntos;

    [SerializeField] private Puntuacion puntuacion;

    public AudioSource clip;

   private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            puntuacion.SumarPuntos(cantidadPuntos);
            ControladorPuntos.Instance.SumarPuntos(cantidadPuntos);
            GetComponent<SpriteRenderer>().enabled = false;
            //FindObjectOfType<FruitManager>().AllFruitsCollected();
            Destroy(gameObject, 0.5f);
            clip.Play();
        }
    }
}
