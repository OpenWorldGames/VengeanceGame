using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject enemy;
	public GameObject boss;
	public Vector3 spawnValues;
	public int waves;
	private int loopCount;
	public int numEnemies;
	public float spawnTime;
	public float startTime;
	public float waitTime;

	// Use this for initialization
	void Start () {
		StartCoroutine (spawnWaves ());
	}
	//Spawn enemies in waves
	IEnumerator spawnWaves () {
		yield return new WaitForSeconds (startTime);
		for (int j= 0; j < waves; j++)
		{
			loopCount++;
			if (loopCount == waves) {
				Vector3 spawnPosition = new Vector3 (0, 8, 0);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (boss, spawnPosition, spawnRotation);
			}
			for (int i = 0; i < numEnemies; i++) {
				Vector3 spawnPosition = new Vector3 (Random.Range (-7, 11), Random.Range (5, 8), spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (enemy, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (spawnTime);
			}
			yield return new WaitForSeconds (waitTime);
		}
	}
}
	