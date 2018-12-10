using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour {

    RectTransform trans;
    [SerializeField]
    float velMov;

	void Awake ()
    {
        trans = GetComponent<RectTransform>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        trans.Translate(Vector3.up * Time.deltaTime * velMov);	
	}
}
