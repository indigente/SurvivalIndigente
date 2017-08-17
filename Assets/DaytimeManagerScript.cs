using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DaytimeManagerScript : MonoBehaviour {

	public Text curDaytime;
	public float timer, timerAux;
	public bool isNight;


	// Use this for initialization
	void Start () {

		isNight = false;
		timer = timerAux;
	}
	
	// Update is called once per frame
	void Update () {

		if (isNight == false) {
			curDaytime.text = "Night";
		} else {
			curDaytime.text = "Day";
		}

		timer -= Time.deltaTime;
		if (timer <= 0) {
			isNight = !isNight;
			timer = timerAux;
		}
	}
}
