using UnityEngine;
using System.Collections;

[System.Serializable]

public class EnemyControl : MonoBehaviour {

   
    
   // Public vars for guns
    public GameObject shot;
	public Transform shotSpawn, shotSpawn2, shotSpawn3,shotSpawn4, shotSpawn5, shotSpawn6, shotSpawn7, shotSpawn8,shotSpawn9,shotSpawn10;
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
			Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
			Instantiate (shot, shotSpawn2.position, shotSpawn2.rotation);
			Instantiate(shot, shotSpawn3.position, shotSpawn3.rotation);
			Instantiate(shot, shotSpawn4.position, shotSpawn4.rotation);
			Instantiate(shot, shotSpawn5.position, shotSpawn5.rotation);
			Instantiate(shot, shotSpawn6.position, shotSpawn6.rotation);
			Instantiate(shot, shotSpawn7.position, shotSpawn7.rotation);
			Instantiate(shot, shotSpawn8.position, shotSpawn8.rotation);
			Instantiate(shot, shotSpawn9.position, shotSpawn9.rotation);
			Instantiate(shot, shotSpawn10.position, shotSpawn10.rotation);
		}
	
	}
  

}
