using UnityEngine;
using System.Collections;

[System.Serializable]

public class EnemyControl : MonoBehaviour {

   
    
   // Public vars for guns
    public GameObject shot;
    public Transform shotSpawn;
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
		if (Time.time >= fireTime + fireInterval) 
		{
			// Instantiate bullet
			fireTime = Time.time; // Reset the timer.
			Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
		}
	}
  

}
