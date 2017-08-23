using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotPlayer : MonoBehaviour {
    private Rigidbody rgb;

	void Awake () {
        rgb = GetComponent<Rigidbody>();
	}
	
	void Update () {
		if(Input.GetButton("Rot"))
	}
}
