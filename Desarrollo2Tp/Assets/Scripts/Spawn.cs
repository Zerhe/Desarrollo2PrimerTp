using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
    [SerializeField]
    private GameObject moneda;
    [SerializeField]
    private GameObject bala;
    private GameObject[] monedas = new GameObject[400];
    private GameObject[] balas = new GameObject[20];
    private float timerSpawn01;
    private float timerSpawn02;
    private int n;
    private int m;

	void Start () {
        timerSpawn01 = 0;
        timerSpawn02 = 0;
        n = 0;
        m = 0;
        for (int i = 0; i < monedas.Length; i++)
        {
            monedas[i] = Instantiate(moneda, RandomPosition(), Quaternion.Euler(0,0,90));
            monedas[i].SetActive(false);
        }
        for (int i = 0; i < balas.Length; i++)
        {
            balas[i] = Instantiate(bala, RandomPosition(), Quaternion.Euler(0, 0, 90));
            balas[i].SetActive(false);
        }
    }
	
	void Update () {
        timerSpawn01 += Time.deltaTime;
        timerSpawn02 += Time.deltaTime;

        if (timerSpawn01 >= 1 && n < monedas.Length)
        {
            monedas[n].SetActive(true);
            timerSpawn01 = 0;
            n++;
        }
        if (timerSpawn02 >= 5 && m < balas.Length)
        {
            balas[m].SetActive(true);
            timerSpawn02 = 0;
            m++;
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
