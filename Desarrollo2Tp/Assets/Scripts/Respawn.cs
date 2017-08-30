using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {
    private Vector3 positionToRespawn;
    private Rigidbody rgb;

	void Start () {
        rgb = GetComponent<Rigidbody>();
	}
	
	void Update () {
		if (transform.position.y < -15)
        {
            positionToRespawn.x = Random.Range(-40, 40);
            positionToRespawn.y = 25;
            positionToRespawn.z = Random.Range(-40, 40);
            transform.position = positionToRespawn;
            //rgb.velocity = Vector3.zero;
            rgb.angularVelocity = Vector3.zero;
        }
	}
}
