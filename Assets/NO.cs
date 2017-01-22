using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NO : MonoBehaviour {

	public GameObject delay;

	// Use this for initialization
	void Start () {
		StartCoroutine(ooo());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator ooo() {
		yield return new WaitForSeconds(3f);

		delay.gameObject.SetActive(true);
	}
}
