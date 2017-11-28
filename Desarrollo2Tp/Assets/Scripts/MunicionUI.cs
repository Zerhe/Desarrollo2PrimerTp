using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MunicionUI : MonoBehaviour {
    [SerializeField]
    private DispararPlayer playerWeapon;
    private Text municionText;

    void Awake()
    {
        municionText = GetComponent<Text>();

    }

    void Update()
    {
        municionText.text = "x" + playerWeapon.GetCantBalas();

    }
}
