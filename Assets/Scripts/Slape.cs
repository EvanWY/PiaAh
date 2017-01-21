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
            RaycastHit2D[] hits;
            hits = Physics2D.CircleCastAll(Input.mousePosition, radius, Camera.main.transform.forward);
            foreach(RaycastHit2D hit in hits)
            {
                var state = hit.collider.GetComponent<ManState>();
                //if( state == ManState.AudienceState.Sleep)
               // {

                //}
            }
        }
	}
}
