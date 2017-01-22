using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slape : MonoBehaviour {

    public float radius;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("1111");
            RaycastHit2D[] hits;
            hits = Physics2D.CircleCastAll(Camera.main.ScreenToWorldPoint(Input.mousePosition), radius, Vector2.zero, Physics2D.AllLayers);
            foreach(RaycastHit2D hit in hits)
            {
                if (hit.collider != null)
                {
                    if (hit.collider.GetComponent<ManState>())
                    {
                        var man = hit.collider.GetComponent<ManState>();
                        Debug.Log(man);
                        if (man.state == ManState.AudienceState.Ready)
                        {
                            man.isSlaped = true;
							MusicSchedule.PlayPlayerDrum();
						}
                    }
                }
            }
        }
	}
}
