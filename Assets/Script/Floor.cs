using UnityEngine;
using System.Collections;

public class Floor : MonoBehaviour {

    public Player player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseUpAsButton()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        player.GoToPosition(mousePos);
    }
}
