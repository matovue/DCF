using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class JumpRobotJump : MonoBehaviour
{
    public GameManaggger GameManager;
    public float velocity = 1;
    private Rigidbody2D rb;
    public GameObject Ground;
    public GameObject Ground1;


    // Start is called before the first frame update
      void Start(){
        rb = GetComponent<Rigidbody2D>();

}

    // Update is called once per frame
     void Update(){
        if (Input.GetMouseButtonDown(0))
        {
            //Jump
            rb.velocity = Vector2.up * velocity;
            //may not need this (test to see if it makes a difference to the rotations)
            transform.rotation = Quaternion.Euler(0,0,0);
            // stops the object's z transform rotation from moving keeps it 0 
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
        
}

    private void OnCollisionEnter2D(Collision2D collision){

    
    if (collision.gameObject.tag == "Ground")
       {
           Physics2D.IgnoreCollision(Ground.GetComponent<Collider2D>(), Ground.GetComponent<Collider2D>());
            
       }
       else if(collision.gameObject.tag == "Ground1")
       {
           Physics2D.IgnoreCollision(Ground1.GetComponent<Collider2D>(), Ground1.GetComponent<Collider2D>());
       }
      else if(collision.contacts[0].normal.y < -0.5)
        {
            GameManager.GameOver();
        }     

       else
       {
        GameManager.GameOver();
        
    }
      
    }
}
