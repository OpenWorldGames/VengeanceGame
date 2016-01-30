using UnityEngine;
using System.Collections;


public class DestroyWhenHit : MonoBehaviour
{
    public GameObject explosion;
    public GameObject playerExplosion;
    private GameController gameController;


	void Start()
	{
		gameController = GameObject.Find ("Game Controller").GetComponent<GameController>();
	}
    void OnTriggerEnter(Collider other)
    
    {
		if (other.tag == "Boundary")
		{
			return;
		}
			
		 else {
		Instantiate(explosion, transform.position,transform.rotation);
		Destroy(other.gameObject);
		Destroy(gameObject);
			print ("Hit!");
			if (other.tag == "Player") {
				gameController.GameOver ();
			}
				
		}
        
	}
}