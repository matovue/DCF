using UnityEngine;
using UnityEngine.SocialPlatforms;  
using UnityEngine.UI; //add when refrencing textbox in unity   
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine.SceneManagement;
using System;
using System.Text;


public class game1 : MonoBehaviour
{

//public Transform highscoreText;

 public Transform checkScoreboardButton;
 
 
    
   public void ScoreChecker() 
    { 
         
               
                checkScoreboardButton.GetComponent<Button>().onClick.AddListener(() => {Social.ShowLeaderboardUI();  });
    }
}

