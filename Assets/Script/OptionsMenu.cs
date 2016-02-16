using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour {

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.P))
		{
			SceneManager.LoadScene(1);
		}
	}

	public void LoadScene(int level)
    {
        
       SceneManager.LoadScene(level);
     

    }
}
