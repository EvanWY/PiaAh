using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerAdjuster : MonoBehaviour {

	// Use this for initialization
	void Start () {
		foreach (var rnd in gameObject.GetComponentsInChildren<SpriteRenderer>()) {
			rnd.sortingOrder += 10000 - Mathf.RoundToInt(1000 * (transform.position.y + 10));
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
