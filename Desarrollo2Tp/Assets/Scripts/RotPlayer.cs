  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotPlayer : MonoBehaviour {
    private Rigidbody rgb;
    private float velRot;
    private bool rotRight;
    private bool rotLeft;
    private string rotXButton;

	void Awake () {
        rgb = GetComponent<Rigidbody>();
        velRot = 0.25f;
        rotRight = false;
        rotLeft = false;
        if (name == "Player1")
            rotXButton = "RotXP1";
        else if (name == "Player2")
            rotXButton = "RotXP2";
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

        if (Input.GetAxis(rotXButton) > 0)
            rotRight = true;
        else if (Input.GetAxis(rotXButton) < 0)
            rotLeft = true;


        if(rgb.rotation.x > 0.3)
            rgb.rotation = Quaternion.Euler(0.3f, rgb.rotation.y, rgb.rotation.z);
        else if (rgb.rotation.x < -0.3)
            rgb.rotation = Quaternion.Euler(-0.3f, rgb.rotation.y, rgb.rotation.z);
        if (rgb.rotation.eulerAngles.z > 15 && rgb.rotation.eulerAngles.z < 300)
            rgb.rotation = Quaternion.Euler(rgb.rotation.eulerAngles.x, rgb.rotation.eulerAngles.y, 15f);
        else if (rgb.rotation.eulerAngles.z < 345 && rgb.rotation.eulerAngles.z > 300)
            rgb.rotation = Quaternion.Euler(rgb.rotation.eulerAngles.x, rgb.rotation.eulerAngles.y, 345f);


    }
}
