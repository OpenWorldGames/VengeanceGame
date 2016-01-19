using UnityEngine;
using System.Collections;


public class BossHp : MonoBehaviour
{
	public int bossHp = 5;
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Boundary")
		{
			return;
		}
		if (bossHp > 1) {
			bossHp = bossHp - 1;
			Destroy (other.gameObject);
			return;
		}
		Destroy(other.gameObject);
		Destroy(gameObject);
	}
}