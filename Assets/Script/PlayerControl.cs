using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, yMin, yMax;
}
public class PlayerControl : MonoBehaviour {

    public float speed;
   // public Text countText;
   // public Text winText;

    private Rigidbody rb;
    // private int count;

    public Boundary boundary;

    public float tilt;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
       // count = 0;
       // SetCountText();
       // winText.text = "";
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
