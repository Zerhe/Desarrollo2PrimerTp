using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotMoneda : MonoBehaviour {
    float velRot;
	void Start () {
        velRot = 10;
	}
	
	void Update () {
        transform.Rotate(Vector3.right * velRot);
	}
}
