using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {
    private AudioSource aud;
	void Awake () {
        aud = GetComponent<AudioSource>();	
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Respawn>().SetTransformPoint(transform);
            aud.Play();
        }      
    }
}
