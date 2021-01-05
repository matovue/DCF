using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner4 : MonoBehaviour
{
    // time we have to wait before new pipe is formed
    public float maxTime = 30;
    //Timer to count the time that is passing
    private float timer = 0;
    // reference to pipe game object we created in the unity app
    public GameObject pipe4;
    public float height;

     public GameObject newpipe;

 

    // Start is called before the first frame update
    void Start()
    {
         
         
       
    }
     
    // Update is called once per frame
    void Update()
    {
          
        
        
        // each time the timer is greater than the max time variable we want to instantiate (create a new of the same thing) our pipe
       // we will modify the height of the pipe slightly by using a randomly generated number ranged between -height and height
        if(timer > maxTime)
        {
           pipe4.SetActive(true); 
           GameObject newpipe = Instantiate(pipe4);
            
            // because we will spawn the pipe infinatley, we can destroy the pipe after some time has passed here its 15
            // 7 as any bigger eg. > 10 causes the spwner to start glitching after some time aroung 6000KB points
            Destroy(newpipe, 7); 
            timer = 0;
            
          
        }
        
        // after spawning we can set the timer to restart
        timer += Time.deltaTime;
        
    }
}
