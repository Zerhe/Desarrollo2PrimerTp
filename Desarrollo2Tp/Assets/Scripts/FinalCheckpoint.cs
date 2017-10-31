using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalCheckpoint : MonoBehaviour {
    [SerializeField]
    private Timer timer;
    private int playerEntry;

	void Start () {
        playerEntry = 0;
	}
	
	void Update () {
		if (playerEntry == 2)
        {
            timer.SetTimerGame(0);
        }
	}
    private void OnTriggerEnter(Collider other)
    {
        print("daleguacha");

        if (other.gameObject.tag == "Player")
        {
            print("daleguacho");
            timer.gameObject.SetActive(true);
            other.gameObject.GetComponent<ScorePlayer>().SumScoreFinal();
            playerEntry++;
        }
    }
}
