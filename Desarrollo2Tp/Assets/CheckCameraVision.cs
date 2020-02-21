using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCameraVision : MonoBehaviour {

    [SerializeField]
    private float velMov;
    private bool checkCamera = false;
    [SerializeField]
    private Transform playerT;
    private float distanceMax;
    private float distanceActual;
    private Vector3 position01;
    private Vector3 position02;
    private bool playerMoving = false;
    private Rigidbody playerRgb;

    private void Awake()
    {
        playerRgb = playerT.gameObject.GetComponent<Rigidbody>();
    }
    void Start ()
    {
        distanceActual = distanceMax = Vector3.Distance(playerT.position, transform.position);
        position02 = position01 = playerT.position;
    }
	
	void Update ()
    {
        //print(playerMoving);
        //print(playerRgb.velocity.magnitude);

        if (playerRgb.velocity.magnitude > 1 )
        {
            playerMoving = true;
        }
        else
            playerMoving = false;

        distanceActual = Vector3.Distance(playerT.position, transform.position);

        if (checkCamera == true && distanceActual > 1.5)
        {
            transform.Translate(Vector3.forward * velMov);
        }
        else if( checkCamera == false && distanceActual < distanceMax && playerMoving)
        {
            transform.Translate(Vector3.forward * -velMov);
        }
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 9)
        {
            checkCamera = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 9)
        {
            checkCamera = false;
        }
    }
}
