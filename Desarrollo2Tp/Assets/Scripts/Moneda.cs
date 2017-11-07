using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour {
    [SerializeField]
    private int valor;
    private float velRot;
    private Rigidbody rgb;
    private CapsuleCollider coll;

    private void Awake()
    {
        rgb = GetComponent<Rigidbody>();
        coll = GetComponent<CapsuleCollider>();
    }
    void Start () {
        velRot = 500;
	}
	
	void Update () {
        transform.Rotate(Vector3.right * Time.deltaTime * velRot);
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Plataforma")
        {
            rgb.useGravity = false;
            coll.isTrigger = true;

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
    public int GetValor()
    {
        return valor;
    }
    public void SetValor(int value)
    {
        valor = value;
    }
}
