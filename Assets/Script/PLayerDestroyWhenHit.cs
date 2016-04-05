using UnityEngine;
using System.Collections;

public class PLayerDestroyWhenHit : MonoBehaviour {

	public GameObject explosion;
	private GameController gameController;
	public int scoreValue;



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
			Instantiate(explosion, transform.position,transform.rotation);
			Destroy(other.gameObject);
			Destroy(gameObject);
			print ("Hit!");
			gameController.GameOver (true);
		}

	}

}