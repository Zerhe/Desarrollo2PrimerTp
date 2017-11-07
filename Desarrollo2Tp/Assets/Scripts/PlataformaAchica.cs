using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaAchica : MonoBehaviour {
    [SerializeField]
    private Timer timer;
    private Vector3 nuevaScala;
    private int maxTimerGame;
    private float maxX;
    private float maxZ;
    private float achicar;

	void Start () {
        maxTimerGame = timer.GetTimerGame();
        maxX = transform.localScale.x;
        maxZ = transform.localScale.z;

    }

    void Update () {
        print(achicar);
        achicar = timer.GetTimerGame() / maxTimerGame;
        nuevaScala.x = maxX * achicar;
        nuevaScala.z = maxZ * achicar;

        transform.localScale = nuevaScala;
	}
}
