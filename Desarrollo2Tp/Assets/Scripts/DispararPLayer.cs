using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispararPlayer : MonoBehaviour {
    private int cantBalas;
    [SerializeField]
    private Transform spawnTransform;
    [SerializeField]
    private GameObject bala;
    private GameObject[] balas = new GameObject[20];
    private string fireButton;
    private int n;

    private void Awake()
    {
        switch (name)
        {
            case "Player1":
                fireButton = "FireP1";
                break;
            case "Player2":
                fireButton = "FireP2";
                break;
        }
    }
    void Start ()
    {
        cantBalas = 100;
        n = 0;
        for (int i = 0; i < balas.Length; i++)
        {
            balas[i] = Instantiate(bala, spawnTransform.position , spawnTransform.rotation);
            balas[i].SetActive(false);
        }
    }
	
	void Update ()
    {
        if (n == balas.Length)
            n = 0;

        if (Input.GetButtonDown(fireButton) && transform.GetChild(0).gameObject.activeInHierarchy && cantBalas > 0)
        {
            balas[n].transform.position = spawnTransform.position;
            balas[n].transform.rotation = spawnTransform.rotation;
            balas[n].SetActive(true);
            cantBalas--;
            n++;
        }
	}
    public int GetCantBalas()
    {
        return cantBalas;
    }
    public void SumCantBalas(int cant)
    {
        cantBalas += cant;
    }
}
