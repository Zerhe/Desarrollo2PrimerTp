  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotPlayer : MonoBehaviour {
    private Rigidbody rgb;
    private float velRot;
    private bool rotRight;
    private bool rotLeft;
    private string rotRightButton;
    private string rotLeftButton;

	void Awake () {
        rgb = GetComponent<Rigidbody>();
        velRot = 0.25f;
        if (name == "Player1")
        {
            rotRightButton = "RotRP1";
            rotLeftButton = "RotLP1";
        }
        else if (name == "Player2")
        {
            rotRightButton = "RotRP2";
            rotLeftButton = "RotLP2";
        }
    }
    void FixedUpdate()
    {
        if (rotRight)
        {
            rgb.AddRelativeTorque(Vector3.up * velRot, ForceMode.VelocityChange );
            rotRight = false;
        }
        if (rotLeft)
        {
            rgb.AddRelativeTorque(Vector3.down * velRot, ForceMode.VelocityChange);
            rotLeft = false;
        }
    }
    void Update() {

        rotRight = Input.GetButton(rotRightButton);
        rotLeft = Input.GetButton(rotLeftButton);


        /*if(rgb.rotation.x > 0.3)
            rgb.rotation = Quaternion.Euler(0.3f, rgb.rotation.y, rgb.rotation.z);
        else if (rgb.rotation.x < -0.3)
            rgb.rotation = Quaternion.Euler(-0.3f, rgb.rotation.y, rgb.rotation.z);*/
        if (rgb.rotation.eulerAngles.z > 15 && rgb.rotation.eulerAngles.z < 300)
            rgb.rotation = Quaternion.Euler(rgb.rotation.eulerAngles.x, rgb.rotation.eulerAngles.y, 15f);
        else if (rgb.rotation.eulerAngles.z < 345 && rgb.rotation.eulerAngles.z > 300)
            rgb.rotation = Quaternion.Euler(rgb.rotation.eulerAngles.x, rgb.rotation.eulerAngles.y, 345f);


    }
}
