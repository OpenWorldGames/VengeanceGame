using UnityEngine;
using System.Collections;


public class DestroyWhenHit : MonoBehaviour
{
    public GameObject explosion;
    public GameObject playerExplosion;
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
		}	}
    void OnTriggerEnter(Collider other)
    
    {
		if (other.tag == "Boundary")
		{
			return;
		}
			
		 else {
		Instantiate(explosion, transform.position,transform.rotation);
		gameController.AddScore (scoreValue);
		Destroy(other.gameObject);
		Destroy(gameObject);
			print ("Hit!");
			if (other.tag == "Player") {
				gameController.GameOver ();
			}
				
		}
        
	}
}