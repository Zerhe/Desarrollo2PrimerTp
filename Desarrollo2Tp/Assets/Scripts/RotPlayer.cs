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

        if (Input.GetButton(rotRightButton))
        {
            print("asdad");
            rotRight = true;
        }
        rotLeft = Input.GetButton(rotLeftButton);

    }
}
