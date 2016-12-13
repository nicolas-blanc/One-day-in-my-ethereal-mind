using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crisis : MonoBehaviour {

    public float timeTransition;
    // Nombre compris entre 0 et 100
    public int ChanceOfCrisis;
	public bool crisisSound;

    private bool crisis;

    private GameObject backgroundCrisis;
	private GameObject soundCrisis;
    private int frame;

    private System.Random rnd;

	// Use this for initialization
	void Start () {
        rnd = new System.Random();

        crisis = false;

		if (crisisSound) {
			soundCrisis = GameObject.FindWithTag("SoundCrisis");
			soundCrisis.GetComponent<AudioSource> ().loop = true;
		}
        backgroundCrisis = GameObject.FindWithTag("BackgroundCrisis");  
	}

    // Update is called once per frame
    void Update()
    {
        if (crisisSound && crisis) {
			// PlaySound
			if (!soundCrisis.GetComponent<AudioSource> ().isPlaying) {
				soundCrisis.GetComponent<AudioSource> ().Play();
				Debug.Log("Start sound");
			}
		} else if(soundCrisis != null) {
			// StopSound
			if (soundCrisis.GetComponent<AudioSource> ().isPlaying) {
				soundCrisis.GetComponent<AudioSource> ().Pause();
				Debug.Log("Stop sound");
			}
		}

        if (frame % 100 == 0)
        {
            Debug.Log("Frame : " + frame);
        }

        if ((frame % 100) == 0 && rnd.Next(100) <= ChanceOfCrisis)
        {
            crisis = true;
            Debug.Log("Change crisis to true");
        }

        if (crisis && GetComponent<SpriteRenderer>().color.a > 0)
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
