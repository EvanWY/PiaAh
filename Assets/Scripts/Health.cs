using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public int initHealth;
    public int currentHealth;
	// Use this for initialization
	void Start () {
        currentHealth = initHealth;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void reduceHealth()
    {
        if(currentHealth == 0)
        {
            Debug.Log("game over");
        }
        if(currentHealth > 0)
        {
            currentHealth--;
            Debug.Log(currentHealth);
        }
    }
}
