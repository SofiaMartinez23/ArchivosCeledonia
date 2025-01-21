using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuevaPanel : MonoBehaviour
{
    [SerializeField] private GameObject cueva;

    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        cueva.SetActive(true);
    }
}
