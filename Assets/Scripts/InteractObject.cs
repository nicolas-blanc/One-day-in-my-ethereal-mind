using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractObject : MonoBehaviour {

	private Collider2D mumu;

	// Use this for initialization
	void Start () {
		mumu = GetComponent<Collider2D>(); 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTrigger() {
		Debug.Log("Mumu");
	}
}
