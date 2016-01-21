using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

	public GameObject enemy;
	public GameObject boss;
	public Vector3 spawnValues;
	public int waves;
	private int loopCount;
	public int numEnemies;
	public float spawnTime;
	public float startTime;
	public float waitTime;

    public GUIText scoreText;
    public GUIText restartText;
    public GUIText gameOverText;

    private bool gameOver;
    private bool restart;
    //private int score;

	// Use this for initialization
	void Start () {
        gameOver = false;
        restart = false;
        restartText.text = "";
        gameOverText.text = "";
        //score = 0;
        //UpdateScore();
        StartCoroutine (spawnWaves ());
	}
	
    void update ()
    {
        if (restart)
        {
            if (Input.GetKeyDown (KeyCode.R))
            {
                SceneManager.LoadScene(1);
            }
        }
    }
    
    //Spawn enemies in waves
	IEnumerator spawnWaves ()
    {    
		yield return new WaitForSeconds (startTime);
        while (true)
        {

            for (int j= 0; j < waves; j++)
		    {
			loopCount++;
			if (loopCount == waves)
            {
				Vector3 spawnPosition = new Vector3 (0, 8, 0);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (boss, spawnPosition, spawnRotation);
			}
        
                for (int i = 0; i < numEnemies; i++)
            {
				Vector3 spawnPosition = new Vector3 (Random.Range (-7, 11), Random.Range (5, 8), spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (enemy, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (spawnTime);
			}
			yield return new WaitForSeconds (waitTime);

                if (gameOver)
            {
                restartText.text = "Press 'R' to Restart";
                restart = true;
                break;
            }
         }
           

          
		}
	}
        /*for score
        public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }
        //updates score
        void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }*/
        //gameover
        public void GameOver()
    {
        gameOverText.text = "Game Over!";
        gameOver = true;
    }

}
	