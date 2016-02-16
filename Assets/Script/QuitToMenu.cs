using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 

public class QuitToMenu : MonoBehaviour {

	public GameObject LoadingImage;



	public void LoadScene(int level) {
			LoadingImage.SetActive(true);
			SceneManager.LoadScene(level);
		}
		

}
