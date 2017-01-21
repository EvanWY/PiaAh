using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineWave : MonoBehaviour {

	public float speed;
	public float waveDuration;
	public bool isTriggered;
	public bool startFromLeft;

	private Vector3 moveDirection;
	private Vector3 initPosition;
	// Use this for initialization
	void Start() {
		initPosition = transform.position;

		if (startFromLeft) {
			moveDirection = Vector3.right;
		}
		else {
			moveDirection = Vector3.left;
		}
	}

	// Update is called once per frame
	void Update() {
		if (isTriggered) {
			StopAllCoroutines();
			transform.position = initPosition;
			StartCoroutine(returnBack());
			isTriggered = false;
		}
	}

	IEnumerator returnBack() {
		var startTime = Time.time;

		while (Time.time - startTime <= waveDuration) {
			transform.Translate(moveDirection * Time.deltaTime * speed);
			yield return 0;
		}
		transform.position = initPosition;
	}
}