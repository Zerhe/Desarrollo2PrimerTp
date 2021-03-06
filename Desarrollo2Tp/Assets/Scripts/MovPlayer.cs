﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlayer : MonoBehaviour
{
    private Rigidbody rgb;
    private Animator anim;
    private bool coliPiso;
    private bool forward;
    private bool back;
    private bool right;
    private bool left;
    private bool push;
    private float vel;
    private float pushVel;
    private float impulsoVel;
    private string moveXButton;
    private string moveYButton;
    private string pushButton;
    [SerializeField]
    private AudioClip pushSong;
    private AudioController audCon;


    private void Awake()
    {
        rgb = GetComponent<Rigidbody>();
        anim = GetComponentInChildren<Animator>();
        audCon = GetComponent<AudioController>();
        vel = 1.5f;
        pushVel = 0;
        impulsoVel = 2;
        forward = false;
        back = false;
        right = false;
        left = false;
        push = false;
    }
    void Start()
    {
        if (name == "Player1")
        {
            moveXButton = "MoveXP1";
            moveYButton = "MoveYP1";
            pushButton = "PushP1";
        }
        else if (name == "Player2")
        {
            moveXButton = "MoveXP2";
            moveYButton = "MoveYP2";
            pushButton = "PushP2";
        }
        anim.SetBool("Idle", true);
    }
    void FixedUpdate()
    {
        if (right)
            rgb.AddRelativeForce(Vector3.right * vel, ForceMode.VelocityChange);
        if (left)
            rgb.AddRelativeForce(Vector3.left * vel, ForceMode.VelocityChange);
        if (forward)
            rgb.AddRelativeForce(Vector3.forward * vel, ForceMode.VelocityChange);
        if (back)
            rgb.AddRelativeForce(Vector3.back * vel, ForceMode.VelocityChange);
        if (push)
        {
            rgb.AddRelativeForce(Vector3.forward * pushVel, ForceMode.VelocityChange);
            pushVel = 0;
            push = false;
            anim.ResetTrigger("Push");
            audCon.PlayAudio(pushSong);
        }
        rgb.AddForce(Vector3.down * 80);

    }
    void Update()
    {
        if (coliPiso)
        {
            if (Input.GetAxis(moveXButton) > 0)
            {
                right = true;
                anim.SetBool("Idle", false);
                anim.SetBool("Forwad", false);
                anim.SetBool("Back", false);
                anim.SetBool("Left", false);
                anim.SetBool("Right", true);
            }
            else
            {
                right = false;
                if(anim.GetBool("Right"))
                {
                anim.SetBool("Right", false);
                anim.SetBool("Idle", true);

                }
            }
            if (Input.GetAxis(moveXButton) < 0)
            {
                left = true;
                anim.SetBool("Idle", false);
                anim.SetBool("Forwad", false);
                anim.SetBool("Back", false);
                anim.SetBool("Right", false);
                anim.SetBool("Left", true);
            }
            else
            {
                left = false;
                if (anim.GetBool("Left"))
                {
                    anim.SetBool("Left", false);
                    anim.SetBool("Idle", true);
                }
            }
            if (Input.GetAxis(moveYButton) > 0)
            {
                back = true;
                anim.SetBool("Idle", false);
                anim.SetBool("Forwad", false);
                anim.SetBool("Right", false);
                anim.SetBool("Left", false);
                anim.SetBool("Back", true);
            }
            else
            {
                back = false;
                if (anim.GetBool("Back"))
                {
                    anim.SetBool("Back", false);
                    anim.SetBool("Idle", true);
                }
            }
            if (Input.GetAxis(moveYButton) < 0)
            {
                forward = true;
                anim.SetBool("Idle", false);
                anim.SetBool("Back", false);
                anim.SetBool("Right", false);
                anim.SetBool("Left", false);
                anim.SetBool("Forwad", true);
            }
            else
            {
                forward = false;
                if (anim.GetBool("Forwad"))
                {
                    anim.SetBool("Forwad", false);
                    anim.SetBool("Idle", true);
                }
            }
            if (Input.GetButton(pushButton))
            {
                if (pushVel < 150)
                {
                    pushVel += Time.deltaTime * 150;
                }

            }
            if (Input.GetButtonUp(pushButton))
            {
                push = true;
                anim.SetTrigger("Push");
            }
        }
    }
    public void ResetTeclas()
    {
        forward = false;
        back = false;
        right = false;
        left = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            rgb.AddForce(collision.relativeVelocity * impulsoVel, ForceMode.VelocityChange);
        }
        if (collision.gameObject.layer == 8)
        {
            transform.SetParent(collision.gameObject.transform.GetChild(0), true);
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Plataforma")
        {
            coliPiso = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Plataforma")
        {
            coliPiso = false;
            ResetTeclas();
        }
        if (collision.gameObject.layer == 8)
        {
            transform.SetParent(null);
        }
    }
    public float getPushVel()
    {
        return pushVel;
    }
}
