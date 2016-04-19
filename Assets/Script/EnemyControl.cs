using UnityEngine;
using System.Collections;

[System.Serializable]

public class EnemyControl : MonoBehaviour {

   
    
   // Public vars for guns
    public GameObject shot;
	public Transform[] shotSpawn;
	public float timer;
	private int waitingTime;

	[SerializeField]private float fireInterval = 0.25f;
	private float fireTime;

    private Rigidbody rb;
    // private int count;

    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
		fireTime = Time.time;
       // count = 0;
       // SetCountText();
       // winText.text = "";
    }

	void Update()
	{
		/*print ("fuck");
		timer += Time.deltaTime;
		if (timer > waitingTime)
		{
			Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
			timer = 0;
		}*/
		CheckInput ();
	}

	void CheckInput()
	{
		FireShell ();
	}

	void FireShell()
	{
		if (Time.time >= fireTime + fireInterval) {
			// Instantiate bullet
			fireTime = Time.time; // Reset the timer.
			Instantiate (shot, shotSpawn[0].position, shotSpawn[0].rotation);
			Instantiate (shot, shotSpawn[1].position, shotSpawn[1].rotation);
			Instantiate (shot, shotSpawn[2].position, shotSpawn[2].rotation);
			Instantiate (shot, shotSpawn[3].position, shotSpawn[3].rotation);
			Instantiate (shot, shotSpawn[4].position, shotSpawn[4].rotation);
			Instantiate (shot, shotSpawn[5].position, shotSpawn[5].rotation);
			Instantiate (shot, shotSpawn[6].position, shotSpawn[6].rotation);
			Instantiate (shot, shotSpawn[7].position, shotSpawn[7].rotation);
			Instantiate (shot, shotSpawn[8].position, shotSpawn[8].rotation);
			Instantiate (shot, shotSpawn[9].position, shotSpawn[9].rotation);

		}
	
	}
  

}
