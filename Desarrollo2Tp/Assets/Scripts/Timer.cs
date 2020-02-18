using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    [SerializeField]
    private GameObject panelWin;
    [SerializeField]
    private Text playerWinText;
    [SerializeField]
    private ScorePlayer scorePlayer01;
    [SerializeField]
    private ScorePlayer scorePlayer02;
    [SerializeField]
    private float timerGame;
    [SerializeField]
    private PlataformaPunto plataformaPunto;
    private float timer;
    private Text timerText;
    private bool sumTimer;

    void Awake () {
        timerText = GetComponent<Text>();
	}
    private void Start()
    {
        timer = 0;
        sumTimer = true;
    }
    void Update () {
        if (sumTimer)
            timer += Time.deltaTime;
        if (timer >= 3)
        {
            timerGame--;
            timer = 0;
        }
        timerText.text = "" + timerGame;

        if (timerGame == 0 && sumTimer)
        {
            sumTimer = false;
            panelWin.SetActive(true);

            /*if (scorePlayer01.GetScore() > scorePlayer02.GetScore())
                scorePlayer01.SumScoreFinal();
            else if (scorePlayer02.GetScore() > scorePlayer01.GetScore())
                scorePlayer02.SumScoreFinal();
            else
            {
                scorePlayer01.SumScoreFinal();
                scorePlayer02.SumScoreFinal();
            }

            if (scorePlayer01.GetDeaths() > scorePlayer02.GetDeaths())
                scorePlayer02.SumScoreFinal();
            else if (scorePlayer02.GetDeaths() > scorePlayer01.GetDeaths())
                scorePlayer01.SumScoreFinal();*/

            if (SceneManager.GetActiveScene().name == "Game")
            {
                if (plataformaPunto.GetValorPunto() > 0)
                    playerWinText.text = "Player01 Win ";
                else if (plataformaPunto.GetValorPunto() < 0)
                    playerWinText.text = "Player02 Win ";
                else
                    playerWinText.text = "Empate";
            }

            if (SceneManager.GetActiveScene().name == "Game3")
            {
                if (scorePlayer01.GetDeaths() > scorePlayer02.GetDeaths())
                    playerWinText.text = "Player02 Win ";
                else if (scorePlayer02.GetDeaths() > scorePlayer01.GetDeaths())
                    playerWinText.text = "Player01 Win ";
                else
                    playerWinText.text = "Empate";
            }

            /*if (scorePlayer01.GetScoreFinal() > scorePlayer02.GetScoreFinal() )
                playerWinText.text = "Player01 Win ";
            else if (scorePlayer02.GetScoreFinal() > scorePlayer01.GetScoreFinal())
                playerWinText.text = "Player02 Win ";
            else
                playerWinText.text = "Empate";*/
        }
    }
    public void SetTimerGame(int valor)
    {
        timerGame = valor;
    }
    public float GetTimerGame()
    {
        return timerGame;
    }
}
