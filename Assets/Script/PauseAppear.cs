using UnityEngine;
using System.Collections;

public class PauseAppear : MonoBehaviour {
	public GameObject pausePanel;

	public bool isPaused;

	void Start() {
	isPaused = false;//game starts unpaused
}

// Update is called once per frame
	void Update () {
		if (isPaused) {
			PauseGame (true);
		} else {
			PauseGame (false);
		}

		if (Input.GetKeyDown (KeyCode.Escape)) { //gets pause keypress
			SwitchPause();
		}
	}


	void PauseGame (bool state){ //pause game function
			if (state) {

				Time.timeScale = 0; //paused
			}
			else {
				Time.timeScale = 1; //Unpaused
			}
			pausePanel.SetActive (state);
		}

	public void SwitchPause(){ 
			if (isPaused) {
				isPaused = false; //Changes value
			} else {
				isPaused = true;
			}
	}	
}
