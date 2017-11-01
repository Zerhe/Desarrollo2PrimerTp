using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    [SerializeField]
    private Transform transformPoint;
    private Rigidbody rgb;
    [SerializeField]
    private ScorePlayer scoreOtherPlayer;
    private ScorePlayer scorePlayer;
    [SerializeField]
    private float minRespawn;
    [SerializeField]
    private float maxRespawn;

    void Awake()
    {
        rgb = GetComponent<Rigidbody>();
        scorePlayer = GetComponent<ScorePlayer>();

    }
    void Start()
    {

    }

    void Update()
    {
        if (transform.position.y < -15)
        {
            //scoreOtherPlayer.SetScore(scoreOtherPlayer.GetScore() + scorePlayer.GetScore());
            //scorePlayer.SetScore(0);
            RespanwnRandom();
            scorePlayer.SumDeaths();
        }
        if (Input.GetButton("Reset"))
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    void RespanwnRandom()
    {
        Vector3 positionToRespawn;
        positionToRespawn.x = Random.Range(-minRespawn, maxRespawn);
        positionToRespawn.y = 25;
        positionToRespawn.z = Random.Range(-minRespawn, maxRespawn);
        positionToRespawn += transformPoint.position;
        transform.position = positionToRespawn;
        rgb.velocity = Vector3.zero;
        rgb.angularVelocity = Vector3.zero;
        //gameObject.GetComponent<MovPlayer>().ResetTeclas();
    }
    public void SetTransformPoint(Transform valor)
    {
        transformPoint = valor;
    }
}
