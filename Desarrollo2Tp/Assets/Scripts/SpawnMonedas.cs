using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMonedas : MonoBehaviour {
    [SerializeField]
    private GameObject moneda;
    private GameObject[] monedas = new GameObject[100];
    int timerSpawn;
    int n;

	void Start () {
        timerSpawn = 0;
        n = 0;
        for (int i = 0; i < monedas.Length; i++)
        {
            monedas[i] = Instantiate(moneda, RandomPosition(), transform.rotation);
            monedas[i].SetActive(false);
        }
    }
	
	void Update () {
        timerSpawn++;
        if(timerSpawn == 200)
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
