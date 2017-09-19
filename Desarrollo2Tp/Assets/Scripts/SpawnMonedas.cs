using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMonedas : MonoBehaviour {
    [SerializeField]
    private GameObject moneda;
    private GameObject[] monedas = new GameObject[400];
    private int timerSpawn;
    private int n;

	void Start () {
        timerSpawn = 0;
        n = 0;
        for (int i = 0; i < monedas.Length; i++)
        {
            monedas[i] = Instantiate(moneda, RandomPosition(), Quaternion.Euler(0,0,90));
            monedas[i].SetActive(false);
        }
    }
	
	void Update () {
        timerSpawn++;
        if(timerSpawn == 50 && n < monedas.Length)
        {
            monedas[n].SetActive(true);
            timerSpawn = 0;
            n++;
        }
	}
    Vector3 RandomPosition()
    {
        Vector3 randomPosition;
        randomPosition.x = Random.Range(-40, 40);
        randomPosition.y = 20;
        randomPosition.z = Random.Range(-40, 40);
        return randomPosition;
    }
}
