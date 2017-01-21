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

	public LineWave wave;

	public static Dictionary<GameObject, bool> dictAudienceInRange = new Dictionary<GameObject, bool>();


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
	float lastFrameTime = -10000;
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
					var cfgString = cfgStringArr[currCfgNum];
					var cfg = cfgString[strIdx % 16];


					if (strIdx < 16) { // demo round
						switch (cfg) {
							case '1': {
									List<GameObject> goArr = new List<GameObject>(dictAudienceInRange.Keys);
									if (goArr != null && goArr.Count != 0) {
										var go = goArr[Random.Range(0, goArr.Count - 1)];
										go.GetComponent<ManState>().state = ManState.AudienceState.Sleep;
									}
									source.PlayOneShot(demoDrumLight);
								}
								break;
							case '2':{
									List<GameObject> goArr = new List<GameObject>(dictAudienceInRange.Keys);
									if (goArr != null && goArr.Count != 0) {
										var go = goArr[Random.Range(0, goArr.Count - 1)];
										go.GetComponent<ManState>().state = ManState.AudienceState.Sleep;
									}
									source.PlayOneShot(drmoDrumHeavy);
								}
								break;
						}
					}
					else { // player round
						switch (cfg) {
							case '1':
								break;
							case '2':
								break;
						}
					}


					if (strIdx == 15) {
						wave.transform.Find("Front").gameObject.SetActive(true);
						wave.transform.Find("Wave").gameObject.SetActive(true);
						wave.transform.Find("Prepare").gameObject.SetActive(false);
					}
					else if (strIdx == 31) {
						dictAudienceInRange.Clear();
						wave.transform.Find("Front").gameObject.SetActive(false);
						wave.transform.Find("Wave").gameObject.SetActive(false);
						wave.transform.Find("Prepare").gameObject.SetActive(true);
					}
				}
			}

		}

		lastFrameTime = currTime;
	}
}
