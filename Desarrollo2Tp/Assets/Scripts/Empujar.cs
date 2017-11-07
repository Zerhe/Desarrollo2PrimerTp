using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Empujar : MonoBehaviour {

    public float impulsoVel;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
            collision.gameObject.GetComponent<Rigidbody>().AddForce(collision.relativeVelocity * impulsoVel, ForceMode.VelocityChange);
    }
}
