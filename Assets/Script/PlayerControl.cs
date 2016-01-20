using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, yMin, yMax;
}
public class PlayerControl : MonoBehaviour {

    public Boundary boundary;
    public float tilt;
    public float speed;



    // Public vars for guns
    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;

    private float nextFire;



    // public Text countText;
    // public Text winText;

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
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        }
    }


    void FixedUpdate()
    {
        rb.velocity = Vector3.zero;
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0.0f);

        rb.AddForce(movement * speed);

            rb.position = new Vector3
                (
                Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax),  
                Mathf.Clamp(rb.position.y, boundary.yMin, boundary.yMax),
                0.0f
                );
            
       
    }

  
}
