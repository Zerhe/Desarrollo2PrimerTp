using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePlayer : MonoBehaviour {
    private int score;
    void Start () {
        score = 0;
	}
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Moneda")
        {
            score++;
        }
    }
    public int getScore()
    {
        return score;
    }
}
