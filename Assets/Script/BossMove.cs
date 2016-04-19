using UnityEngine;
using System.Collections;


public class BossMove : MonoBehaviour {
	public int moveSpeed = 5;  //per second 
	Vector3 computerDirection = Vector3.down; 
	Vector3 moveDirection = Vector3.zero; 
	Vector3 newPosition = Vector3.zero; 
	public int minY = 0;
	private Rigidbody rb;
	private bool check = true;
	void Start () {
		rb = GetComponent<Rigidbody>();
	}

	void Update ()
	{
		Vector3 newPosition = new Vector3 (0, -1, 0) * (moveSpeed * Time.deltaTime);  
		newPosition = transform.position + newPosition;  
		newPosition.y = Mathf.Clamp (newPosition.y, minY, 126);  
		transform.position = newPosition; 
		if (newPosition.y <= minY) {
			if (newPosition.x > 8) {
				check = false;
			} 
			if (newPosition.x < -8) {
				check = true;
			}
			if (check) {
				//print ("hit!3");
				transform.Translate (Vector3.right * moveSpeed * Time.deltaTime);
				rb.position = new Vector3 (Mathf.Clamp (rb.position.x, -8, 8), Mathf.Clamp (rb.position.y, -8, 8), 0.0f);
			} else {
				//print ("hit!2");
				transform.Translate (Vector3.left * moveSpeed * Time.deltaTime);
				rb.position = new Vector3 (Mathf.Clamp (rb.position.x, -8, 8), Mathf.Clamp (rb.position.y, -8, 8), 0.0f);
			}
		}
	}	
}
