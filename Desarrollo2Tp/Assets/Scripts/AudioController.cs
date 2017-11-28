using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour {
    private AudioSource aud;
    [SerializeField]
    private AudioClip coinSong;
    [SerializeField]
    private AudioClip ammoSong;

	void Awake () {
        aud = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Moneda")
            PlayAudio(coinSong);
        else if (other.gameObject.tag == "Municion")
            PlayAudio(ammoSong);
    }
    public void PlayAudio(AudioClip clip)
    {
        Debug.Log("aasdad");
        aud.clip = clip;
        aud.Play();
    }
}
