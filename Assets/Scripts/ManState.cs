using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManState : MonoBehaviour {

    public static AudienceState state;
    private Animator anim;
	// Use this for initialization
	void Start () {
        state = AudienceState.Idle;
        anim = transform.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        switch (state)
        {
            case AudienceState.Idle:

                break;
            case AudienceState.Wave:
                break;
            case AudienceState.Sleep:
                
                break;
        }
	}

    public void SetToIdle()
    {
        state = AudienceState.Idle;
    }

    public void SetToSleep()
    {
        state = AudienceState.Sleep;
    }

    public void SetToWave()
    {
        state = AudienceState.Wave;
    }

    public enum AudienceState
    {
        Idle,
        Wave,
        Sleep,
    }
}
