using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public static int missNum;
	// Use this for initialization

    public static void ReduceHealth()
    {
        missNum++;
    }
}
