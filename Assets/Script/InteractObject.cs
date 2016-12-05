using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractObject : MonoBehaviour {
    public GUIManager GUIMgr;

	public Text label;
	public string msg;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	

	public void OnMouseUpAsButton()
    {
        GUIMgr.showUI(EnumUI.Object);
		label.text = msg;
    }
}
