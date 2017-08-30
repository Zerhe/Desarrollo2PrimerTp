using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlayer : MonoBehaviour {
    private Rigidbody rgb;
    private bool coliPiso;
    private bool forwad;
    private bool back;
    private bool right;
    private bool left;
    private bool push;
    private float vel;
    private float pushVel;
    private float impulsoVel;
    private string forwadButton;
    private string backButton;
    private string rightButton;
    private string leftButton;
    private string pushButton;


    private void Awake()
    {
        rgb = GetComponent<Rigidbody>();
        vel = 3;
        pushVel = 0;
        impulsoVel = 2;
        forwad = false;
        back = false;
        right = false;
        left = false;
        push = false;
    }
    void Start ()
    {
        if(name == "Player1")
        {
            forwadButton = "ForwadP1";
            backButton = "BackP1";
            rightButton = "RightP1";
            leftButton = "LeftP1";
            pushButton = "PushP1";
        }
        else if (name == "Player2")
        {
            forwadButton = "ForwadP2";
            backButton = "BackP2";
            rightButton = "RightP2";
            leftButton = "LeftP2";
            pushButton = "PushP2";
        }
    }
    void FixedUpdate()
    {
        if (forwad)
        {
            rgb.AddRelativeForce(Vector3.forward * vel, ForceMode.VelocityChange);
        }

        if (back)
        {
            rgb.AddRelativeForce(Vector3.back * vel, ForceMode.VelocityChange);
        }

        if (right)
        {
            rgb.AddRelativeForce(Vector3.right * vel, ForceMode.VelocityChange);
        }

        if (left)
        {
            rgb.AddRelativeForce(Vector3.left * vel, ForceMode.VelocityChange);
        }

        if (push)
        {
            //print("asd");
            rgb.AddRelativeForce(Vector3.forward * pushVel , ForceMode.VelocityChange);
            pushVel = 0;
            push = false;
        }
        rgb.AddForce(Vector3.down * 50);

    }
    void Update ()
    {
        if (coliPiso)
        {
            if (Input.GetButton(forwadButton))
            {
                forwad = true;
            }
            else
                forwad = false;
            if (Input.GetButton(backButton))
            {
                back = true;
            }
            else
                back = false;
            if (Input.GetButton(rightButton))
            {
                right = true;
            }
            else
                right = false;
            if (Input.GetButton(leftButton))
            {
                left = true;
            }
            else
                left = false;
            if (Input.GetButton(pushButton))
            {
                if (pushVel < 350)
                {
                    pushVel += 2;
                }
                print(pushVel);

            }
            if (Input.GetButtonUp(pushButton))
            {
                push = true;
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Piso")
        {
            coliPiso = true;
        }
        if (collision.gameObject.tag == "Player")
        {
            rgb.AddForce(collision.relativeVelocity * impulsoVel, ForceMode.VelocityChange);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Piso")
        {
            coliPiso = false;
        }
    }
}
