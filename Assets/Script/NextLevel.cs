using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

	public GameObject LoadingImage;

	public void nextLevel(){
		int indexSC = SceneManager.GetActiveScene ().buildIndex;
		SceneManager.LoadScene (indexSC + 1);
		LoadingImage.SetActive(true);
	}
}
