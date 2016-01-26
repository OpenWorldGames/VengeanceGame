using UnityEngine;
using System.Collections;


public class DestroyWhenHit : MonoBehaviour
{
    public GameObject explosion;
    public GameObject playerExplosion;
    private GameController gameController;
    void OnTriggerEnter(Collider other)
    
    {
		if (other.tag == "Boundary")
		{
			return;
		}
        Instantiate(explosion, transform.position,transform.rotation);
        if(other.tag == "player")
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            gameController.GameOver ();
        }
        Destroy(other.gameObject);
		Destroy(gameObject);
	}
}