﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gameoverMenu : MonoBehaviour
{
    public Text highscoreText;
    // Start is called before the first frame update
    void Start()
    {
      highscoreText.text = "HighScore :" + ((int)PlayerPrefs.GetFloat ("HighScore")).ToString();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
