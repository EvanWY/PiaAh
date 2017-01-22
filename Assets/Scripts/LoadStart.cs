using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadStart : MonoBehaviour {

    public void loadStart()
    {
        SceneManager.LoadScene("start");
    }

}
