using UnityEngine;
using UnityEngine.SocialPlatforms;  
using UnityEngine.UI; //add when refrencing textbox in unity   

using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI; //add when refrencing text in unity 
using UnityEngine.SceneManagement;

public class game : MonoBehaviour 
{

    
    int scorea;

    void Start () 
    {
         scorea= Score.scoreValue;
         // This mean you try to login the user to the game center
         Social.localUser.Authenticate (ProcessAuthentication);

    }

    // This is the function that process the user login, after user login successfully, you create a leaderboard with id "com.dvf.leaderboard", must match the ID you created on appleconnect
    void ProcessAuthentication (bool success) 
    {
    

        if (success) 
        {
            Debug.Log ("Authentication successful");
            Social.CreateLeaderboard();
            Social.CreateLeaderboard().id = "com.dvf.leaderboard";

        }
        else
        {
            Debug.Log ("Failed to authenticate");
        }
    }

    // This is the function that show 2 button, button 1 "Submit" let you submit your highscore to the leaderboard, button 2 "Stat" will load the game center showing your highscore
    void OnGUI() 
    {
            if(GUI.Button (new Rect (480f,1500f,300f,300f), "<color=white><size=80>SUBMIT</size></color>"))
            {
                Social.ReportScore(scorea,"com.dvf.leaderboard",HighScoreCheck);

            }


            if(GUI.Button (new Rect (950f,1500f,300f,300f), "<color=white><size=40>STAT</size></color>"))
            {
                Social.ShowLeaderboardUI();


            }

    }

    // This is the function that tells you if the score submission is successful or not
    static void HighScoreCheck(bool result) 
    {
        if(result)
            Debug.Log("score submission successful");
        else
            Debug.Log("score submission failed");
    }
}