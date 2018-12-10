using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour {
    [SerializeField]
    private GameObject camera01;
    [SerializeField]
    private GameObject camera02;
    private string cameraButton;

    void Start () {
        if (name == "Player1")
            cameraButton = "CameraP1";
        else if (name == "Player2")
            cameraButton = "CameraP2";
    }
	
	void Update () {
		if (Input.GetButtonDown(cameraButton))
        {
            if(camera01.activeInHierarchy)
            {
                camera01.SetActive(false);
                camera02.SetActive(true);
            }
            else if (camera02.activeInHierarchy)
            {
                camera02.SetActive(false);
                camera01.SetActive(true);
            }
        }
	}
}
