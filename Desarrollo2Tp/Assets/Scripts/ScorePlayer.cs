using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePlayer : MonoBehaviour {
    private int score;
    private int deaths;
    private int scoreFinal;
    void Start () {
        score = 0;
        scoreFinal = 0;
	}
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Moneda")
        {
            score += other.gameObject.GetComponent<Moneda>().GetValor();
        }
    }
    public int GetScore()
    {
        return score;
    }
    public void SetScore(int valor)
    {
        score = valor;
    }
    public int GetDeaths()
    {
        return deaths;
    }
    public void SumDeaths()
    {
        deaths++;
    }
    public int GetScoreFinal()
    {
        return scoreFinal;
    }
    public void SumScoreFinal()
    {
        scoreFinal++;
    }
}
