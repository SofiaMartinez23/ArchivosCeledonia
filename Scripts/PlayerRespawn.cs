using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{

    public Animator animator;
    public string respawnSceneName;

    public void PlayerDamaged()
    {
        animator.Play("Hit");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(respawnSceneName);
    }
}
