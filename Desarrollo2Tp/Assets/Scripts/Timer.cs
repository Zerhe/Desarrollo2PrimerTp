using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    private Text timerText;
    [SerializeField]
    private GameObject panelWin;
    [SerializeField]
    private Text playerWinText;
    [SerializeField]
    private ScorePlayer scorePlayer01;
    [SerializeField]
    private ScorePlayer scorePlayer02;
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

        if (timerGame == 4)
        {
            panelWin.SetActive(true);
            if (scorePlayer01.getScore() > scorePlayer02.getScore() )
            {
                playerWinText.text = "Player01 Win Congratulñaiotionsada < 3";
            }
            else
            {
                playerWinText.text = "Player02 Win Congratulñaiotionsada < 3";
            }
        }
	}
}
