using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSchedule : MonoBehaviour {

	public float BPM;
	public float startDelay;
	public AudioSource bgm;
	public AudioSource source;

	public AudioClip demoDrumLight;
	public AudioClip drmoDrumHeavy;
	public AudioClip playerDrumLight;
	public AudioClip playerDrumHeavy;


	// "1000100010001000"
	public string[] cfgStringArr;

	float startTime;
	float beatDelta;

	// Use this for initialization
	void Start () {
		startTime = Time.time + startDelay;
		bgm.Play();

		beatDelta = 60f / (BPM * 4);
	}

	// Update is called once per frame
	float lastFrameTime;
	void Update () {
		var currTime = Time.time - startTime;
		Debug.Log(currTime);
		if (currTime >= 0) {
			int currBeatNum = Mathf.FloorToInt(currTime / beatDelta);
			int lastFrameBeatNum = Mathf.FloorToInt(lastFrameTime / beatDelta);

			if (lastFrameBeatNum < currBeatNum) {
				int currCfgNum = currBeatNum / 32;
				int strIdx = currBeatNum % 32;

				//Debug.Log(currCfgNum + " " + strIdx);

				if (currCfgNum < cfgStringArr.Length) {
					if (strIdx < 16) { // demo round
						var cfgString = cfgStringArr[currCfgNum];
						var cfg = cfgString[strIdx];

						switch (cfg) {
							case '1':
								source.PlayOneShot(demoDrumLight);
								break;
							case '2':
								source.PlayOneShot(drmoDrumHeavy);
								break;
						}
					}
					else { // player round

					}
				}
			}

		}

		lastFrameTime = currTime;
	}
}
