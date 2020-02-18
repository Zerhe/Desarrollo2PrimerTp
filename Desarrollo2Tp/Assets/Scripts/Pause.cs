using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {
    [SerializeField]
    private GameObject pausePanel;

	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButton("Cancel") && !pausePanel.activeInHierarchy)
        {
            pausePanel.SetActive(true);
            Cursor.visible = true;
            Time.timeScale = 0;
        }
        else if (Input.GetButton("Cancel") && pausePanel.activeInHierarchy)
        {
            Cursor.visible = false;
            Time.timeScale = 1;
            pausePanel.SetActive(false);
        }
    }
}
