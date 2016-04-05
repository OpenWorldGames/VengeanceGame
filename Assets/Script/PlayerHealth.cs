using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
	public GameObject healthBar;
	public int hp = 2;

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
}
