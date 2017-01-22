using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameEnd : MonoBehaviour {


    public GameObject gameOverPanel;
    public Text score;
    public Sprite[] results;
    private int finalScore;
	// Use this for initialization

	void Start () {
        finalScore = Score.currentScore;
        score.text = finalScore.ToString();

        if()
	}
}
