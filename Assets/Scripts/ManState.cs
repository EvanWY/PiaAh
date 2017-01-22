using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManState : MonoBehaviour {

    public AudienceState state, lastFrameState, nextState;
    public bool isSlaped;
    private Animator anim;

	// Use this for initialization
	void Start () {
        state = AudienceState.Idle;
        anim = transform.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log(state);
		nextState = state;

		switch (state)
        {
            case AudienceState.Idle:
				if (lastFrameState != state) {
					if (lastFrameState == AudienceState.Slap)
						GetComponent<Animator>().SetTrigger("slap");
					else
						GetComponent<Animator>().SetTrigger("idle");
				}
                break;
            case AudienceState.Wave:
				if (lastFrameState != state) {
					GetComponent<Animator>().SetTrigger("wave");
				}
				break;
            case AudienceState.Sleep:
				if (lastFrameState != state) {
					GetComponent<Animator>().SetTrigger("sleep");
				}
				if (isSlaped) {
				}
				break;
            case AudienceState.Ready:
				if (isSlaped) {
					nextState = AudienceState.Slap;
				}
                break;
			case AudienceState.Slap:
				nextState = AudienceState.Idle;
				break;
        }

		lastFrameState = state;
		state = nextState;
		isSlaped = false;
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 10)
        {
			if (state == AudienceState.Ready) {
				//Health.ReduceHealth();
				state = AudienceState.Idle;
			}
			else {
				state = AudienceState.Wave;
			}
		}
		else if (collision.gameObject.layer == 9 && state == AudienceState.Sleep) {
			state = AudienceState.Ready;
		}

		if (collision.gameObject.layer == 11) {
			MusicSchedule.dictAudienceInRange[gameObject] = true;
			//Debug.Log("11233");
		}

	}

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 10 && state == AudienceState.Wave)
        {
            state = AudienceState.Idle;
		}

		if (collision.gameObject.layer == 11) {
			if (MusicSchedule.dictAudienceInRange.ContainsKey(gameObject))
				MusicSchedule.dictAudienceInRange.Remove(gameObject);
			//Debug.Log("3333");
		}
	}

    public enum AudienceState
    {
        Idle,
        Wave,
        Sleep,
        Ready,
		Slap,

    }
}
