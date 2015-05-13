using System;
using UnityEngine;
using UnityEngine;
using System.Collections;
public class Pausemenu : MonoBehaviour 
{
	public bool paused = false;
	
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Escape) && paused == false) 
		{
			paused = true;
			Time.timeScale = 0.0f;
			Screen.showCursor = true;
			GetComponent<ThirdPersonController>().enabled = false;
		} 
		else if (Input.GetKeyDown (KeyCode.Escape) && paused == true) 
		{
			paused = false;
			Time.timeScale = 1.0f;
			Screen.showCursor = false;
			GetComponent<ThirdPersonController>().enabled = true;
		}
	}
	
	void OnGUI () {
		{
			if (paused == true)
				GUI.Button (new Rect (Screen.width / 2 - 100, Screen.height / 2 + 25, 250, 50), "Options");
			if (paused == true)
				if (GUI.Button (new Rect (Screen.width / 2 - 100, Screen.height / 2 - 25, 250, 50), "Resume"));
		}
	}
}
