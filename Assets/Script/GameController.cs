using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
	//public CharacterSelect;
	public GameObject QuitPanel;
	public GameObject StoryPanel;
	public GameObject enemy;
	public GameObject boss;
	public Vector3 spawnValues;
	public int waves;
	private int loopCount;
	public int numEnemies;
	public float spawnTime;
	public float startTime;
	public float waitTime;
	private PauseAppear pauseAppear;
	public int highscore = 0;
	private float gameTime;
	private int combo;
	public GameObject[] ship; 

	//public GUIText scoreText;
	public GUIText comborestartText;
	public GUIText comboText;
	public GUIText scoreText;

	private bool gameOver;
	private bool restart;
	public int score;


	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("Score", score);
		if(PlayerPrefs.HasKey("Score")) {
			print ("devour");
			if (Application.loadedLevel == 3) {
				PlayerPrefs.DeleteKey("Score");
				score = 0;
				print ("collect");
			}
		} else {
			score = PlayerPrefs.GetInt("Score");
			print ("remove");
		}

	//	print ("Player1" + CharacterSelect.player1);
	//	print ("Player2" + CharacterSelect.player2);
	//	print ("Player3" + CharacterSelect.player3);
	//	print ("Player4" + CharacterSelect.player4);
		spawnPlayer ();
		DontDestroyOnLoad (ship[0]);
		DontDestroyOnLoad (ship[1]);
		DontDestroyOnLoad (ship[2]);
		DontDestroyOnLoad (ship[3]);
		gameOver = false;
		restart = false;
		//restartText.text = "";
		//gameOverText.text = "";
		score = 0;
		UpdateScore();
		StartCoroutine (spawnWaves ());
		StoryPanel.SetActive (false);
		QuitPanel.SetActive (false);
		Time.timeScale = 1; 
	}
	void Update ()
	{
		scoreSave ();


	}

	//Spawn enemies in waves
	IEnumerator spawnWaves () {    
		yield return new WaitForSeconds (startTime);
		for (int j = 0; j < waves; j++) {
			loopCount++;
			if (loopCount == waves) {
				Vector3 spawnPosition = new Vector3 (0, 8, 0);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (boss, spawnPosition, spawnRotation);
			} for (int i = 0; i < numEnemies; i++) {
				Vector3 spawnPosition = new Vector3 (Random.Range (-7, 11), Random.Range (5, 8), spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (enemy, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (spawnTime);
			}
			yield return new WaitForSeconds (waitTime);
		}
	}
	//for score
	public void AddScore(int newScoreValue)
	{

		if (gameTime <= 10) {
			score += newScoreValue * combo;
			combo++;
			comboText.text = combo + "X Combo";
			gameTime = 0;
			//print (gameTime);
			UpdateScore ();
		} else {
			combo = 1; 
			comborestartText.text = "combo reset" + combo;
			gameTime = 0;
			//print (gameTime);
			Destroy(gameObject);
		}

	}
	//updates score
	void UpdateScore()
	{
		scoreText.text = "score: " + score;
		scoreSave ();

	}
	//gameover
	public void GameOver(bool state)
	{
		//paused
		print ("Game Over!");
		QuitPanel.SetActive (state);

	}
	public void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	public void ShowPanel(string text){

		StoryPanel.SetActive (true);
	}
	public void scoreSave()
	{
		//DontDestroyOnLoad (Score);
	}

	public void spawnPlayer(){
		Vector3 playerPosition = new Vector3 (0, -3, 0);
		if (CharacterSelect.player1) {
			//print ("Player 1 ship");
			Instantiate (ship [0], playerPosition, transform.rotation);
		} else if (CharacterSelect.player2) {
			//print ("Player 2 ship");
			Instantiate (ship [1], playerPosition, transform.rotation);
		} else if (CharacterSelect.player3) {
			//print ("Player 3 ship");
			Instantiate (ship [2], playerPosition, transform.rotation);
		} else if (CharacterSelect.player4) {
			//print ("Player 4 ship");
			Instantiate (ship [3], playerPosition, transform.rotation);
		}

	}
}
