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
        print(transform.rotation);

        rotRight = Input.GetButton(rotRightButton);
        rotLeft = Input.GetButton(rotLeftButton);

        if(transform.rotation.x > 0.3)
            transform.rotation = Quaternion.Euler(0.3f, transform.rotation.y, transform.rotation.z);
        else if (transform.rotation.x < -0.3)
            transform.rotation = Quaternion.Euler(-0.3f, transform.rotation.y, transform.rotation.z);
        if (transform.rotation.z > 0.3)
            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 0.3f);
        else if (transform.rotation.z < -0.3)
            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, -0.3f);


    }
}
