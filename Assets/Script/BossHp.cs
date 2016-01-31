﻿using UnityEngine;
using System.Collections;


public class BossHp : MonoBehaviour
{
	public GameObject explosion;
	public GameObject playerExplosion;
	//public int scoreValue;
	//private GameController gameController;
	
	public int bossHp = 5;
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Boundary")
		{
			return;
		}
		if (bossHp > 1) {
			bossHp -= 1;
			//gameController.AddScore (scoreValue);
			Destroy (other.gameObject);

			return;
		}
		Instantiate(explosion, transform.position,transform.rotation);
		//gameController.AddScore (scoreValue);
		Destroy(other.gameObject);
		Destroy(gameObject);
	}
}