using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameEnd : MonoBehaviour {


    public GameObject gameOverPanel;
    public Text score;
    public Sprite[] results;
    public int threshold;
    private int finalScore;
    private int totalMiss;
    private Image im;
	// Use this for initialization

	void Start () {
        im = GetComponent<Image>();
        finalScore = Score.currentScore;
        score.text = finalScore.ToString();
        totalMiss = Health.missNum;

        if( totalMiss == 0)
        {
            im.sprite = results[0];
        }
        if( 0<totalMiss && totalMiss < threshold)
        {
            im.sprite = results[1];
        }
        if( threshold < totalMiss)
        {
            im.sprite = results[2];
        }
	}
}
