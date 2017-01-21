using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManState : MonoBehaviour {

    public static AudienceState state;
    public Health playerHealth;
    public bool isSlaped;
    private Animator anim;

	// Use this for initialization
	void Start () {
        state = AudienceState.Sleep;
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
            case AudienceState.Ready:
                break;
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 10)
        {
            if(state == AudienceState.Idle || state == AudienceState.Ready)
            {
                state = AudienceState.Wave;
                Debug.Log(state);
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 9 && state == AudienceState.Sleep)
        {
            Debug.Log("can be slaped");
            if (isSlaped)
            {
                state = AudienceState.Ready;
                Debug.Log(state);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 10 && state == AudienceState.Wave)
        {
            state = AudienceState.Idle;
            Debug.Log(state);
        }
        if(collision.gameObject.layer == 9 && state == AudienceState.Sleep)
        {
            Debug.Log("damage");
            playerHealth.reduceHealth();
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
