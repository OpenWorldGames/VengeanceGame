using UnityEngine;
using System.Collections;

[System.Serializable]

public class EnemyControl : MonoBehaviour {

   
    
    // Public vars for guns
    public GameObject shot;
    public Transform shotSpawn;
    

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
        Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
    }

  
}
