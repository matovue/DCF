using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    // time we have to wait before new pipe is formed
    public float maxTime = 1;
    //Timer to count the time that is passing
    private float timer = 0;
    // reference to pipe game object we created in the unity app
    public GameObject pipe;
    public float height;

     public GameObject newpipe;

 

    // Start is called before the first frame update
    void Start()
    {
          newpipe = Instantiate(pipe);
         newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
          
     
         
       
    }
     
    // Update is called once per frame
    void Update()
    {
          
        if (newpipe.transform.position.y  < -0.5){
            
        newpipe.transform.position = new Vector3(0, 0, 0);
        print("sucess: " + newpipe.transform.position.y );
        }
        
        // each time the timer is greater than the max time variable we want to instantiate (create a new of the same thing) our pipe
       // we will modify the height of the pipe slightly by using a randomly generated number ranged between -height and height
        if(timer > maxTime)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);

            if (newpipe.transform.position.y  < -0.5){
            
                newpipe.transform.position = new Vector3(0, 0, 0);
        
            }
            // because we will spawn the pipe infinatley, we can destroy the pipe after some time has passed here its 15
            // 7 as any bigger eg. > 10 causes the spwner to start glitching after some time aroung 6000KB points
            Destroy(newpipe, 7); 
            timer = 0;
            
         print("TEST: " + newpipe.transform.position.y);  
        }
        
        // after spawning we can set the timer to restart
        timer += Time.deltaTime;
        
    }
}
