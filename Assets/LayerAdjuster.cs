using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerAdjuster : MonoBehaviour {

	// Use this for initialization
	void Start () {
		foreach (var rnd in gameObject.GetComponentsInChildren<SpriteRenderer>()) {
			rnd.sortingOrder += 1000 - Mathf.RoundToInt(100 * (transform.position.y + 10));
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
