using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

    public static int currentScore;
	// Use this for initialization
	void Start () {
        currentScore = 0;
	}

    public static void AddScore()
    {
        if(Health.currentHealth > 0)
        {
            currentScore += 10;
        }
    }
}
