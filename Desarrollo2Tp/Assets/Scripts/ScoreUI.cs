using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour {
    [SerializeField]
    private ScorePlayer playerScore;
    private Text scoreText;

    void Awake () {
        scoreText = GetComponent<Text>();

    }
	
	void Update () {
        scoreText.text = "Score: " + playerScore.GetScore();

    }
}
