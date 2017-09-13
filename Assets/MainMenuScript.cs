using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainMenuScript : MonoBehaviour {

	public bool paused;
	public GameObject myPanelObject;

	void Start(){
		Time.timeScale = 1;
		paused = false;
	}

	void Update(){
		if (Input.GetKeyDown(KeyCode.Escape)) {
			PauseGame ();
		}

		//print (paused);
	
		myPanelObject.SetActive (paused);
	
	}


	public void PauseGame(){
		if (Time.timeScale == 1) {
			Time.timeScale = 0;
			paused = true;
		} else if (Time.timeScale == 0) {
			Time.timeScale = 1;
			paused = false;
		}
	}

	public void ResumeButton(){
		if (paused) {
			Time.timeScale = 1;
			paused = false;
		}
	}

	public void OptionsButton(){
	
	}

	public void QuitButton(){
		SceneManager.LoadScene ("Menu");

	}
}
