using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bazuka : MonoBehaviour {
    [SerializeField]
    private GameObject bazukaPlayer01;
    [SerializeField]
    private GameObject bazukaPlayer02;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player01")
        {
            //if (bazukaPlayer01.enable
        }
    }

}
}
