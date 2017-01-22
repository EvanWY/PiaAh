using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameStart : MonoBehaviour {

    public void loadGame()
    {
        SceneManager.LoadScene("main");
    }
}
