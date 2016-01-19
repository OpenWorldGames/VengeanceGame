using UnityEngine;
using System.Collections;


public class BossMove : MonoBehaviour {
	public int moveSpeed = 4;  //per second 
	Vector3 computerDirection = Vector3.down; 
	Vector3 moveDirection = Vector3.zero; 
	Vector3 newPosition = Vector3.zero; 
	public int minY = 0;

	void Start () {

	}

	void Update () {
		Vector3 newPosition = new Vector3(0,-1,0) * (moveSpeed * Time.deltaTime);  
		newPosition = transform.position + newPosition;  
		newPosition.y = Mathf.Clamp(newPosition.y, minY, 126);  
		transform.position = newPosition; 
		if(newPosition.y > 126)
		{
			newPosition.y = 126;
			computerDirection.y *= -1;	
		}
		else if(newPosition.y < minY)
		{
			newPosition.y = minY;
			computerDirection.y *= -1;
		}  

	}
}
