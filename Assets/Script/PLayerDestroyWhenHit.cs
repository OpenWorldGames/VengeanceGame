using UnityEngine;
using System.Collections;

public class PLayerDestroyWhenHit : MonoBehaviour {



	private GameController gameController;
	public int scoreValue;
	public PlayerHealth PH;


	void Start()
	{
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if (gameControllerObject != null)
		{
			gameController = gameControllerObject.GetComponent <GameController>();
		}
		if (gameController == null)
		{
			Debug.Log ("Cannot find 'GameController' script");
		}	
	}
	void OnTriggerEnter(Collider other) {

		if (other.tag == "Boundary") {
			return;
		} else if (other.tag == "Bullet") {
			return;
		} else {
			
			//Destroy(other.gameObject);
			//Destroy(gameObject);
			PH.deductH();
			print ("Hit!");

		}

	}

}