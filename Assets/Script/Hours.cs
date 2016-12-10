using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hours : MonoBehaviour {

    public Text textHours;

	// Update is called once per frame
	void Update () {
        textHours.text = ConstantObject.getTimeToString();
	}
}
