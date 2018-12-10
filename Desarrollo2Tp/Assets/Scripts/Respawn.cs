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
    private Timer timer;
    [SerializeField]
    float height;
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
            if (SceneManager.GetActiveScene().name != "Game3")
            {
                RespanwnRandom();
                scorePlayer.SumDeaths();
            }
            else
            {
                scoreOtherPlayer.SumScoreFinal();
                timer.SetTimerGame(0);
            }
        }
    }
    void RespanwnRandom()
    {
        Vector3 positionToRespawn;
        positionToRespawn.x = Random.Range(-minRespawn, maxRespawn);
        positionToRespawn.y = height;
        positionToRespawn.z = Random.Range(-minRespawn, maxRespawn);
        positionToRespawn += transformPoint.position;
        transform.position = positionToRespawn;
        rgb.velocity = Vector3.zero;
        rgb.angularVelocity = Vector3.zero;
    }
    public void SetTransformPoint(Transform valor)
    {
        transformPoint = valor;
    }
}
