using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispararPlayer : MonoBehaviour
{
    [SerializeField]
    private int cantBalas;
    [SerializeField]
    private Transform spawnTransform;
    [SerializeField]
    private GameObject bala;
    private GameObject[] balas = new GameObject[20];
    private string fireButton;
    private int n;
    [SerializeField]
    private Material balaMaterial;
    private Color balaLightColor;
    private AudioController audCon;
    [SerializeField]
    private AudioClip disparoSong;

    private void Awake()
    {
        switch (name)
        {
            case "Player1":
                fireButton = "FireP1";
                balaLightColor = Color.red;
                break;
            case "Player2":
                fireButton = "FireP2";
                balaLightColor = Color.blue;
                break;
        }
        audCon = GetComponent<AudioController>();
    }
    void Start()
    {
        n = 0;
        for (int i = 0; i < balas.Length; i++)
        {
            balas[i] = Instantiate(bala, spawnTransform.position, spawnTransform.rotation);
            balas[i].GetComponent<Light>().color = balaLightColor;
            balas[i].GetComponent<MeshRenderer>().material = balaMaterial;
            balas[i].SetActive(false);
        }
    }

    void Update()
    {
        if (n == balas.Length)
            n = 0;

        if (Input.GetButtonDown(fireButton) && transform.GetChild(0).gameObject.activeInHierarchy && cantBalas > 0)
        {
            balas[n].transform.position = spawnTransform.position;
            balas[n].transform.rotation = spawnTransform.rotation;
            balas[n].GetComponent<Rigidbody>().Sleep();
            balas[n].SetActive(true);
			balas[n].GetComponent<Bala>().AddVelocity();
            audCon.PlayAudio(disparoSong);
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
