using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalCheckpoint : MonoBehaviour {
    //[SerializeField]
    //private Timer timer;
    //private int playerEntry;

    [SerializeField]
    private GameObject panelWin;
    [SerializeField]
    private Text playerWinText;

    void Start () {
        //playerEntry = 0;
	}
	
	void Update () {
		/*if (playerEntry == 2)
        {
            timer.SetTimerGame(0);
        }*/
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            /*timer.gameObject.SetActive(true);
            other.gameObject.GetComponent<ScorePlayer>().SumScoreFinal();
            playerEntry++;*/

            panelWin.SetActive(true);
            playerWinText.text = other.name + "Win";
        }
    }
}
