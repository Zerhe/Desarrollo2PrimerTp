using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour {
    private Vector3 positionToRespawn;
    private Rigidbody rgb;
    [SerializeField]
    private ScorePlayer scoreOtherPlayer;
    private ScorePlayer scorePlayer;

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
        }
        if (Input.GetButton("Reset"))
            SceneManager.LoadScene("Game");
    }
    void RespanwnRandom()
    {
        positionToRespawn.x = Random.Range(-40, 40);
        positionToRespawn.y = 25;
        positionToRespawn.z = Random.Range(-40, 40);
        transform.position = positionToRespawn;
        //rgb.velocity = Vector3.zero;
        rgb.angularVelocity = Vector3.zero;
    }
}
