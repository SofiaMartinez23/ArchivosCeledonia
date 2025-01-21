using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tienda : MonoBehaviour   
{
    [SerializeField] private GameObject tienda;

    private void OnCollisionEnter2D(Collision2D collision2D) {
        tienda.SetActive(true);
    }
}
