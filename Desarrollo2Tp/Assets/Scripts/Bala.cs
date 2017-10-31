using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour {
    [SerializeField]
    private float velMov;
    [SerializeField]
    private float velImpulso;

	void Start () {
		
	}
	
	void Update () {
        transform.Translate(Vector3.forward * velMov * Time.deltaTime);
	}
    private void OnCollisionEnter(Collision collision)
    {
        gameObject.SetActive(false);
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(collision.relativeVelocity * velImpulso, ForceMode.VelocityChange);
        }
       
    }
}
