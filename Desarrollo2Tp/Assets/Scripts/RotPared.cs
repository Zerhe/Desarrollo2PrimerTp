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
            timerRot++;
        }
        else if (rotRight)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * velRot);
            timerRot--;
        }
        if (timerRot == 40)
        {
            rotLeft = false;
            rotRight = true;
        }
        else if (timerRot == -10)
        {
            rotRight = false; ;
            rotLeft = true; ;
        }
    }
}
