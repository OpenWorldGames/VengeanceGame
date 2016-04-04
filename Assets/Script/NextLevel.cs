using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

	public void nextLevel(){
		int indexSC = SceneManager.GetActiveScene ().buildIndex;
		SceneManager.LoadScene (indexSC + 1);
	}
}
