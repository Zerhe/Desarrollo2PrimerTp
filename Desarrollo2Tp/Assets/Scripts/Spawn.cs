using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
    [SerializeField]
    private GameObject moneda;
    [SerializeField]
    private GameObject municion;
    private GameObject[] monedas = new GameObject[100];
    private GameObject[] municiones = new GameObject[20];
    private float timerSpawn01;
    private float timerSpawn02;
    private int n;
    private int m;
    [SerializeField]
    private float tiempoSpawnMonedas;
    [SerializeField]
    private float tiempoSpawnMuniciones;


    void Start () {
        timerSpawn01 = 0;
        timerSpawn02 = 0;
        n = 0;
        m = 0;
        for (int i = 0; i < monedas.Length; i++)
        {
            monedas[i] = Instantiate(moneda, RandomPosition(), Quaternion.Euler(0,0,90));
            monedas[i].GetComponent<Moneda>().SetValor(5);
            monedas[i].SetActive(false);
        }
        for (int i = 0; i < municiones.Length; i++)
        {
            municiones[i] = Instantiate(municion, RandomPosition(), Quaternion.Euler(0, 0, 90));
            municiones[i].SetActive(false);
        }
    }
	
	void Update () {
        timerSpawn01 += Time.deltaTime;
        timerSpawn02 += Time.deltaTime;

        if (timerSpawn01 >= tiempoSpawnMonedas && n < monedas.Length)
        {
            monedas[n].SetActive(true);
            timerSpawn01 = 0;
            n++;
        }
        if (timerSpawn02 >= tiempoSpawnMuniciones && m < municiones.Length)
        {
            municiones[m].SetActive(true);
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
