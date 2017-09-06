using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Turbo : MonoBehaviour {
    [SerializeField]
    private MovPlayer playerTurbo;
    private Slider sliderTurbo;

    void Awake () {
        sliderTurbo = GetComponent<Slider>();
	}

	void Update () {
        sliderTurbo.value = playerTurbo.getPushVel();
	}
}
