using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotPared : MonoBehaviour {
    bool rotRight;
    bool rotLeft;
    float velRot;
    float timerRot;

	void Start () {
        rotLeft = true;
        rotRight = false;
        velRot = 100;
        timerRot = 0;
	}
	
	void Update () {
		if(rotLeft)
        {
            transform.Rotate(Vector3.down * Time.deltaTime * velRot);
            timerRot += Time.deltaTime;
        }
        else if (rotRight)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * velRot);
            timerRot -= Time.deltaTime;
        }
        if (timerRot > 1)
        {
            rotLeft = false;
            rotRight = true;
        }
        else if (timerRot < 0)
        {
            rotRight = false; ;
            rotLeft = true; ;
        }
    }
}
