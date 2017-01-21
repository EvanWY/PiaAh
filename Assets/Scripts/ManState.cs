using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManState : MonoBehaviour {

    public static AudienceState state;
    public bool isSlaped;
    private Animator anim;

	// Use this for initialization
	void Start () {
        state = AudienceState.Sleep;
        anim = transform.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(state);


        switch (state)
        {
            case AudienceState.Idle:

                break;
            case AudienceState.Wave:
                break;
            case AudienceState.Sleep:
				if (isSlaped) {
				}
				break;
            case AudienceState.Ready:
				if (isSlaped) {
					state = AudienceState.Idle;
				}
                break;
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 10)
        {
			if (state == AudienceState.Ready) {
				Health.ReduceHealth();
				state = AudienceState.Idle;
			}
			else {
				state = AudienceState.Wave;
			}
		}
		else if (collision.gameObject.layer == 9 && state == AudienceState.Sleep) {
			state = AudienceState.Ready;
		}
	}

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 10 && state == AudienceState.Wave)
        {
            state = AudienceState.Idle;
        }
    }

    public enum AudienceState
    {
        Idle,
        Wave,
        Sleep,
        Ready,
    }
}
