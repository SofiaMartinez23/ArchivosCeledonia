using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class FruitManager : MonoBehaviour
{

    private TMP_Text levelCleared;
    private TMP_Text scoreTotales;
    private TMP_Text scoreCogidas;

    private int totalFrutasEnLevel;

    public void Start() 
    {
        totalFrutasEnLevel = transform.childCount;

    }

    private void Update()
    {
        AllFruitsCollected();
        scoreTotales.text = totalFrutasEnLevel.ToString();
        scoreCogidas.text = transform.childCount.ToString();
    }


    public void AllFruitsCollected()
    {
        if (transform.childCount == 0)
        {
            Debug.Log("No quedan frutas, Victori");
            levelCleared.gameObject.SetActive(true);
            Invoke("ChangeScene", 1);
        }
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
}
