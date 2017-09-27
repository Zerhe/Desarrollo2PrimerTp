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
    private bool sumTimer;

	void Awake () {
        timerText = GetComponent<Text>();
	}
    private void Start()
    {
        timer = 0;
        timerGame = 100;
        sumTimer = true;
    }
    void Update () {
        if (sumTimer)
            timer += Time.deltaTime;
        if (timer >= 1)
        {
            timerGame--;
            timer = 0;
        }
        timerText.text = "" + timerGame;

        if (timerGame == 0 && sumTimer)
        {
            sumTimer = false;
            panelWin.SetActive(true);
            if (scorePlayer01.GetScore() > scorePlayer02.GetScore() )
            {
                playerWinText.text = "Player01 Win <3";
            }
            else if (scorePlayer02.GetScore() > scorePlayer01.GetScore())
            {
                playerWinText.text = "Player02 Win <3";
            }
            else
                playerWinText.text = "Empate";
        }
    }
}
