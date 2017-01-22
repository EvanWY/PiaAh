using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameStart : MonoBehaviour {

    public float startDelay;
    public Animator anim;

    public void loadGame()
    {
        anim.SetTrigger("Big");
        StartCoroutine(bigAndPlay());
    }

    IEnumerator bigAndPlay()
    {
        yield return new WaitForSeconds(startDelay);
        SceneManager.LoadScene("main");
    }
}
