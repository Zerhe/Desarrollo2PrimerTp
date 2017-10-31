using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DeathsUI : MonoBehaviour {
    [SerializeField]
    private ScorePlayer playerScore;
    private Text deathsText;

    void Awake()
    {
        deathsText = GetComponent<Text>();

    }

    void Update()
    {
        deathsText.text = "Deaths: " + playerScore.GetDeaths();

    }
}
