using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
	public GameObject Sparks;
	public GameObject healthBar;
	public int hp = 2;
	public GameController gameController;
	public GameObject explosion;

	// Use this for initialization
	void Start () {
		for (float i = 0; i < hp; i++)
		{
			Vector3 hpPos = new Vector3 (-5.4f+(i/7), -4.5f, 0);
			Quaternion rotate = Quaternion.identity;
			healthBar.name = "healthBar" + (i+1);
			Instantiate(healthBar, hpPos, rotate);
		
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
	public void deductH () {
		if (hp > 1) {
			hp -= 1;
			print (hp);
			Instantiate (Sparks, transform.position,transform.rotation);
			DestroyImmediate (healthBar);
		} else  {
			print("player destroyed");
			Destroy (gameObject);		
			gameController.GameOver (true);
			Instantiate(explosion, transform.position,transform.rotation);
		}
			
	}
}
