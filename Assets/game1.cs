using UnityEngine;
using UnityEngine.SocialPlatforms;  
using UnityEngine.UI; //add when refrencing textbox in unity   

using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine.SceneManagement;


public class game1 : MonoBehaviour
{

 int scorea;
 
   public void Who() 
    { 
          scorea = Score.scoreValue;  
                Social.ReportScore(scorea,"com.dvf.leaderboard",HighScoreCheck);

    }

     static void HighScoreCheck(bool result) 
    {
        if(result)
            Debug.Log("score submission successful");
        else
            Debug.Log("score submission failed");
    }
}
