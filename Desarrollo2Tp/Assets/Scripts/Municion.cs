using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Municion : MonoBehaviour {
    private Rigidbody rgb;
    private SphereCollider coll;

    private void Awake()
    {
        rgb = GetComponent<Rigidbody>();
        coll = GetComponent<SphereCollider>();
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
            other.gameObject.GetComponent<DispararPlayer>().SumCantBalas(1);
            Destroy(this.gameObject);
        }
    }
}
