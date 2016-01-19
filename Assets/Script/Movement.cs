using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public int moveSpeed = 5;  //per second 
	Vector3 computerDirection = Vector3.down; 
	Vector3 moveDirection = Vector3.zero; 
	Vector3 newPosition = Vector3.zero; 

	void Start () {

	}

	void Update () {
		Vector3 newPosition = new Vector3(0,-1,0) * (moveSpeed * Time.deltaTime);  
		newPosition = transform.position + newPosition;  
		newPosition.y = Mathf.Clamp(newPosition.y, -101, 126);  
		transform.position = newPosition; 
		if(newPosition.y > 126)
		{
			newPosition.y = 126;
			computerDirection.y *= -1;	
		}
		else if(newPosition.y < -101)
		{
			newPosition.y = -101;
			computerDirection.y *= -1;
		}  

	}
}
