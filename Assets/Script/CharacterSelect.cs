using UnityEngine;
using System.Collections;

public class CharacterSelect : MonoBehaviour {
	public NextLevel nl;
	public static bool player1;
	public static bool player2;
	public static bool player3;
	public static bool player4;
	// Use this for initialization
	void Start () {
		player1 = false;
		player2 = false;
		player3 = false;
		player4 = false;
		print (player1);
		print (player2);
		print (player3);
		print (player4);
	}
	
	// Update is called once per frame
	public void onClick () {
		player1 = true;
		print (player1);
		nl.nextLevel ();
	}
	public void onClick2 () {
		player1 = true;
		print (player2);
		nl.nextLevel ();
	}
	public void onClick3 () {
		player1 = true;
		print (player3);
		nl.nextLevel ();
	}
	public void onClick4 () {
		player1 = true;
		print (player4);
		nl.nextLevel ();
	}
}
