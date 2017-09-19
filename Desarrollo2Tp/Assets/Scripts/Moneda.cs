﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour {
    private float velRot;
    private Rigidbody rgb;
    private CapsuleCollider coll;

    private void Awake()
    {
        rgb = GetComponent<Rigidbody>();
        coll = GetComponent<CapsuleCollider>();
    }
    void Start () {
        velRot = 10;
	}
	
	void Update () {
        transform.Rotate(Vector3.right * velRot);
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Plataforma")
        {
            rgb.useGravity = false;
            coll.isTrigger = true;

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}