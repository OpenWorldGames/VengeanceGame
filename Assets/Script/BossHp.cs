using UnityEngine;
using System.Collections;


public class BossHp : MonoBehaviour
{
	public GameObject explosion;
	public GameObject playerExplosion;
	public int scoreValue;
	public GameController gameController;
   
	void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
    }
	public int bossHp = 5;
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Boundary") {
			return;
		} else if (other.tag == "Shot") {
			return;
		}
			
        if (bossHp > 1)
        {
            bossHp -= 1;
            Destroy(other.gameObject);
            //player destroyed if hit boss above 1 hp and game over
            if (other.tag == "Player")
            {
                print("hit!");
                gameController.GameOver();
            }
            return;

        }
        
        else
        {
            Instantiate(explosion, transform.position, transform.rotation);
            gameController.AddScore(scoreValue);
            Destroy(other.gameObject);
            Destroy(gameObject);
			print ("hi");

			gameController.ShowPanel ("test");

            // player destroyed if hit boss 1 hp and game over
            if (other.tag == "Player")
            {
                gameController.GameOver();
            }
            
        }

	}
}