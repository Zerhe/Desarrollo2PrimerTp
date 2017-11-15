using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour {

    [SerializeField]
    private float velMov;
    [SerializeField]
    private float velAum;
    private Vector3 direccion;
    private float timer;
	void Start () {
        DireccionRandom();
	}
	void Update () {
        transform.Translate(direccion * Time.deltaTime * velMov);
        timer += Time.deltaTime;
        if (timer > 4)
        {
            velMov += velAum;
            timer = 0;
        }
        if (velMov > 20)
            velMov = 20;
	}
    void DireccionRandom()
    {
        switch (Random.Range(1, 4))
        {
            case 1:
                direccion = Vector3.right + Vector3.forward;
                break;
            case 2:
                direccion = Vector3.right + Vector3.back;
                break;
            case 3:
                direccion = Vector3.left + Vector3.forward;
                break;
            case 4:
                direccion = Vector3.left + Vector3.back;
                break;
            }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Pared01")
        {
            if (direccion == Vector3.right + Vector3.forward)
                direccion = Vector3.left + Vector3.forward;
            else if (direccion == Vector3.left + Vector3.forward)
                direccion = Vector3.right + Vector3.forward;
            else if (direccion == Vector3.right + Vector3.back)
                direccion = Vector3.left + Vector3.back;
            else if (direccion == Vector3.left + Vector3.back)
                direccion = Vector3.right + Vector3.back;
        }
        else if (collision.gameObject.tag == "Pared02")
        {
            if (direccion == Vector3.right + Vector3.forward)
                direccion = Vector3.right + Vector3.back;
            else if (direccion == Vector3.left + Vector3.forward)
                direccion = Vector3.left + Vector3.back;
            else if (direccion == Vector3.right + Vector3.back)
                direccion = Vector3.right + Vector3.forward;
            else if (direccion == Vector3.left + Vector3.back)
                direccion = Vector3.left + Vector3.forward;
        }
    }
}
