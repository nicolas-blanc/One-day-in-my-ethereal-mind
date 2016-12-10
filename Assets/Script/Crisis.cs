using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crisis : MonoBehaviour {

    public float timeTransition;

    private bool crisis;

    private GameObject backgroundCrisis;
    private int frame;

	// Use this for initialization
	void Start () {
        crisis = false;

        backgroundCrisis = GameObject.FindWithTag("BackgroundCrisis");  
	}

    // Update is called once per frame
    void Update()
    {
        if (frame % 100 == 0)
        {
            Debug.Log("Frame : " + frame);
        }

        if (frame == 300)
        {
            crisis = true;
            Debug.Log("Change crisis to true");
        }

        if (crisis && backgroundCrisis.GetComponent<SpriteRenderer>().color.a < 1)
        {
            float alphaPerSecond = 1 / timeTransition;

            if (frame % 60 == 0)
            {
                Debug.Log("Frame : " + frame + "\nalphaPerSecond : " + alphaPerSecond + " // alpha frame : " + (alphaPerSecond * Time.deltaTime) + "\nAlpha background : " + GetComponent<SpriteRenderer>().color.a);
            }

            GetComponent<SpriteRenderer>().color -= new Color(0, 0, 0, alphaPerSecond * Time.deltaTime);
            backgroundCrisis.GetComponent<SpriteRenderer>().color += new Color(0, 0, 0, alphaPerSecond * Time.deltaTime);
        }

        frame++;
    }
}
