using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonChangeScene : MonoBehaviour {
    private Button button;
    private Reg functions;
    [SerializeField]
    private string sceneLoadName;

	void Awake () {
        button = GetComponent<Button>();
        functions = GameObject.FindGameObjectWithTag("GlobalObject").GetComponent<Reg>();
	}
    void Start()
    {
        if(sceneLoadName != "Exit")
            button.onClick.AddListener(delegate () { functions.ChangeScene(sceneLoadName); });
        else
            button.onClick.AddListener(delegate () { functions.Exit(); });

    }
}
