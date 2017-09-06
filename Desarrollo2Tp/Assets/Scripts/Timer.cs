using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    private Text timerText;
    private float timer;
    private float timerGame;

	void Awake () {
        timerText = GetComponent<Text>();
	}
    private void Start()
    {
        timer = 0;
    }
    void Update () {
        timer++;
        if(timer == 50)
        {
            timerGame++;
            timer = 0;
        }
        timerText.text = "" + timerGame;
	}
}
