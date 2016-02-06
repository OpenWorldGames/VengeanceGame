using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public Transform mainMenu, optionsMenu;

    public GameObject LoadingImage;

    public void LoadScene(int level)
    {
        LoadingImage.SetActive(true);
      SceneManager.LoadScene(level);

    }
	
}
