using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour {
    private Vector3 positionToRespawn;
    [SerializeField]
    private Transform transformPoint;
    private Rigidbody rgb;
    [SerializeField]
    private ScorePlayer scoreOtherPlayer;
    private ScorePlayer scorePlayer;
    private int deathsPlayer;
    [SerializeField]
    private float minRespawn;
    [SerializeField]
    private float maxRespawn;

    void Start () {
        rgb = GetComponent<Rigidbody>();
        scorePlayer = GetComponent<ScorePlayer>();
	}
	
	void Update () {
        if (transform.position.y < -15)
        {
            scoreOtherPlayer.SetScore(scoreOtherPlayer.GetScore() + scorePlayer.GetScore());
            scorePlayer.SetScore(0);
            RespanwnRandom();
            deathsPlayer++;
        }
        if (Input.GetButton("Reset"))
            SceneManager.LoadScene("Game");
    }
    void RespanwnRandom()
    {
        positionToRespawn.x = Random.Range(-minRespawn, maxRespawn);
        positionToRespawn.y = 25;
        positionToRespawn.z = Random.Range(-minRespawn, maxRespawn);
        positionToRespawn += transformPoint.position;
        transform.position = positionToRespawn;
        //rgb.velocity = Vector3.zero;
        rgb.angularVelocity = Vector3.zero;
    }
    public int GetDeaths()
    {
        return deathsPlayer;
    }
    public void SetTransformPoint(Transform valor)
    {
        transformPoint = valor;
    }
}
