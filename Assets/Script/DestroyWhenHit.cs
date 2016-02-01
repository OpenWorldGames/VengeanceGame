using UnityEngine;
using System.Collections;


public class DestroyWhenHit : MonoBehaviour
{
    public GameObject explosion;
    public GameObject playerExplosion;
    private GameController gameController;
	private PlayerHealth playerHealth;
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

		GameObject playerHealthObject = GameObject.FindWithTag ("HealthBar");
		if (playerHealthObject != null)
		{
			playerHealth = playerHealthObject.GetComponent <PlayerHealth>();
		}
		if (playerHealth == null)
		{
			Debug.Log ("Cannot find 'PlayerHealth' script");
		}
	}
    void OnTriggerEnter(Collider other)
    
    {
		if (other.tag == "Boundary")
		{
			return;
		}
			
		 else {
		Instantiate(explosion, transform.position,transform.rotation);
		Destroy(gameObject);
			print ("Hit!");
			if (other.tag == "Player")
			{
				if (playerHealth.hp > 1)
				{
					string obj = "healthBar" + playerHealth.hp + "(Clone)";
					Destroy(GameObject.Find(obj));
					playerHealth.hp = playerHealth.hp - 1;
					print ("Player hit!");

				}
				else
				{
					Destroy (GameObject.Find ("healthBar1(Clone)"));
					playerHealth.hp = 0;
					Destroy (other.gameObject);
					gameController.GameOver ();
				}
			} 
				else 
			{
				Destroy(other.gameObject);
				gameController.AddScore (scoreValue);
			}
				
		}
        
	}
}