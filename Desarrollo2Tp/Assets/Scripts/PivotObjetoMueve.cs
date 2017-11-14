using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PivotObjetoMueve : MonoBehaviour {
    private Vector3 newScale;
	void Start () {
        newScale.x = 1 / transform.parent.localScale.x;
        newScale.y = 1 / transform.parent.localScale.y;
        newScale.z = 1 / transform.parent.localScale.z;

        transform.localScale = newScale;
	}
	
	void Update () {
		
	}
}
