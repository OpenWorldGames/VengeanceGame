using UnityEngine;
using System.Collections;

[System.Serializable]

public class EnemyControl : MonoBehaviour {

   
    
    // Public vars for guns
    public GameObject shot;
    public Transform shotSpawn;
	public float timer;

	private int waitingTime;

    private Rigidbody rb;
    // private int count;

    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
       // count = 0;
       // SetCountText();
       // winText.text = "";
    }

    void Update()
	{
		print ("fuck");
		timer += Time.deltaTime;
		if (timer > waitingTime) {
			Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
			timer = 0;
		}
	}
  
}
