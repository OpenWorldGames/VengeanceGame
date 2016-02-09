using UnityEngine;
using System.Collections;

public class PauseAppear : MonoBehaviour 
{


	private bool isShowing;

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.P))
		{
			if (Time.timeScale == 1)
			{
				Time.timeScale = 0;
			}
			else
			{
				Time.timeScale = 1;
			}
		}
	
	}
}
