﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This Script was created for the fire animation using Time.timeScale = 1; to solve the problem of main menu 
// fire animation pausing when you come back to the scene from another scene, JUST ADDED THIS SCRIPT TO 
//(game scene -> fire object) and it worked
public class AnimationCont : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      Time.timeScale = 1;    
    }
}
