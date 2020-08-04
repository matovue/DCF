using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float speed;
    private Rigidbody2D rb;
   
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    // every frame of the game we move our pipe to the left
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime; 
        // stops the object z transform rotation from moving keeps it 0 
        //(Prevents firedrop toppelling over when it lands)  
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }
}
