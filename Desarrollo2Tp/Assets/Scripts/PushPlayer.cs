using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushPlayer : MonoBehaviour {

    [SerializeField]
    float pushForce;
    [SerializeField]
    float maxForce;
    Vector3 finalForce;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            finalForce = collision.relativeVelocity.normalized * pushForce;
            print(finalForce);
            collision.gameObject.GetComponent<Rigidbody>().AddForce(finalForce, ForceMode.VelocityChange);
        }
    }
}
