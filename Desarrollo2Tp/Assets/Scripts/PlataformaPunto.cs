using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaPunto : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    private float timer01;
    private float timer02;

    void Awake()
    {
        timer01 = 0;
        timer02 = 0;
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        print(timer01);
        print(timer02);

        if (timer01 > 10)
        {
            meshRenderer.material.color = Color.red;
            timer01 = 0;
        }
        if (timer02 > 10)
        {
            meshRenderer.material.color = Color.blue;
            timer02 = 0;
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "Player1")
            timer01 += Time.deltaTime;
        else if (collision.gameObject.name == "Player2")
            timer02 += Time.deltaTime;
    }
}
