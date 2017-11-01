using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour {

    [SerializeField]
    private float velMov;
    private Vector3 direccion;
	void Start () {
        DireccionRandom();
	}
	void Update () {
        transform.Translate(direccion * Time.deltaTime * velMov);
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
    private void OnCollisionEnter(Collision collision)
    {
        print("asd");
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
