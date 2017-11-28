using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    [SerializeField]
    private float velMov;
    [SerializeField]
    private float velImpulso;
    private Rigidbody rgb;
    private float timer;

    private void Awake()
    {
        rgb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > 2)
        {
            gameObject.SetActive(false);
            timer = 0;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {        
        if (collision.gameObject.tag == "Player")
        {
            print(rgb.velocity);
            collision.gameObject.GetComponent<Rigidbody>().AddForce(rgb.velocity * velImpulso , ForceMode.VelocityChange);
        }
        gameObject.SetActive(false);
        timer = 0;
    }
	public void AddVelocity()
	{
		rgb.AddRelativeForce(Vector3.forward * velMov, ForceMode.VelocityChange);
	}
}
