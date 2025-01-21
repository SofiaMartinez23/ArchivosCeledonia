using System.Collections;
using UnityEngine;
using TMPro;

public class DialogoNPC : MonoBehaviour
{
    [SerializeField] private GameObject dialogeMark;
    [SerializeField] private GameObject panelDialogo;
    [SerializeField] private TMP_Text dialogo;
    [SerializeField, TextArea(4, 6)] private string[] dialogueLines;

    private float typingTime = 0.05f;

    private bool isPlayerInRange;
    private bool didDialogueStrar;
    private int lineIndex;


    void Update()
    {
        if (isPlayerInRange && Input.GetButtonDown("Fire2"))
        {

            if (!didDialogueStrar)
            {
                StartDialogue();
            }
            else if (dialogo.text == dialogueLines[lineIndex]) 
            {
                NextDialogueLine();

            }
            else
            {
                StopAllCoroutines();
                dialogo.text = dialogueLines[lineIndex];
            }
            
        }  
    }

    private void StartDialogue()
    {
        
        didDialogueStrar = true;
        panelDialogo.SetActive(true);
        dialogeMark.SetActive(false);
        lineIndex = 0;
        Time.timeScale = 0f;
        StartCoroutine(ShowLine());
    }

    private IEnumerator ShowLine()
    {
        dialogo.text = string.Empty;

        foreach (char ch in dialogueLines[lineIndex])
        {
            dialogo.text += ch;
            yield return new WaitForSecondsRealtime(typingTime);
        }
    }

    private void NextDialogueLine()
    {
        lineIndex++;
        if(lineIndex < dialogueLines.Length)
        {
            StartCoroutine(ShowLine());
        }
        else
        {
            didDialogueStrar = false;
            panelDialogo.SetActive(false);
            dialogeMark.SetActive(true);
            Time.timeScale = 1f;
        }
    }
  

  //-------------------------------------------------------------//

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.CompareTag("Player"))
        {

            isPlayerInRange = true;
            dialogeMark.SetActive(true);
            
            //Debug.Log("Se puede iniciar un dialogo");
        }
        
    }
    private void OnTriggerExit2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.CompareTag("Player"))
        {
            isPlayerInRange = false;
            dialogeMark.SetActive(false);
           //Debug.Log("No se puede iniciar un dialogo");
        }
    }
}
