using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameEnd : MonoBehaviour {


    public GameObject gameOverPanel;
    public Text score;
    public Image perfect;
    public Image cool;
    public Image pia;
    public int threshold;
    private int finalScore;
    private int totalMiss;
    //private Image im;
	// Use this for initialization

	void Start () {
        gameOverPanel.SetActive(true);
        //im = GetComponent<Image>();
        finalScore = Score.currentScore;
        score.text = finalScore.ToString();
        totalMiss = Health.missNum;

        Score.currentScore = 0;
        Health.missNum = 0;

        if( totalMiss == 0)
        {
            cool.enabled = false;
            pia.enabled = false;
        }
        if( 0<totalMiss && totalMiss < threshold)
        {
            //im.sprite = cool;
            perfect.enabled = false;
            pia.enabled = false;
        }
        if( threshold < totalMiss)
        {
            //im.sprite = pia;
            perfect.enabled = false;
            cool.enabled = false;
        }
	}
}
