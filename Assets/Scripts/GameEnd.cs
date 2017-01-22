using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameEnd : MonoBehaviour {

    public GameObject endingPanel;
    public Text finalScore;

    public Text perfectText;
    public Text loseText;
	// Use this for initialization
	void Start () {

        endingPanel.SetActive(true);
        finalScore.text = Score.currentScore.ToString();

        //if (Health.currentHealth <= 0)
        //{
        //    loseText.enabled = true;
        //}
        //else
        //{
        //    perfectText.enabled = true;
        //}
	}
}
