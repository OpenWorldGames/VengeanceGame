﻿using UnityEngine;
using System.Collections;

public class CharacterSelect : MonoBehaviour {
	public NextLevel nl;
	public static bool player1= false;
	public static bool player2= false;
	public static bool player3= false;
	public static bool player4= false;
	// Use this for initialization
	void Start () {
		print (player1);
	}

	// Update is called once per frame
	public void onClick () {
		player1 = true;
		print (player1);
		nl.nextLevel ();
	}
	public void onClick2 () {
		player2 = true;
		print (player2);
		nl.nextLevel ();
	}
	public void onClick3 () {
		player3 = true;
		print (player3);
		nl.nextLevel ();
	}
	public void onClick4 () {
		player4 = true;
		print (player4);
		nl.nextLevel ();
	}
}