using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Empujar : MonoBehaviour {

    public float impulsoVel;
    private void Start()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        print("ttt");
        if (collision.gameObject.tag == "Player")
        {
            print("asdsafafasfa");
            collision.gameObject.GetComponent<Rigidbody>().AddForce(collision.relativeVelocity * impulsoVel, ForceMode.VelocityChange);
        }
    }
}
