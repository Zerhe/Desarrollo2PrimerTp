﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bazuka : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (other.gameObject.transform.GetChild(0).gameObject.activeInHierarchy == false)
            {
                other.gameObject.transform.GetChild(0).gameObject.SetActive(true);
                gameObject.SetActive(false);
            }
        }
    }
}
