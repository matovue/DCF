using UnityEngine;
using UnityEngine.SocialPlatforms;  
using UnityEngine.UI; //add when refrencing textbox in unity   
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine.SceneManagement;


public class game1 : MonoBehaviour
{

public Transform highscoreText;
public Transform sendScoreButton;
 public Transform checkScoreboardButton;
 private long Highscore; // Gamecenter requires a long variable
 
    
   public void Who() 
    { 
          highscoreText.GetComponent<Text>().text = Highscore.ToString(); 
                sendScoreButton.GetComponent<Button>().onClick.AddListener(() => { ReportScore(Highscore, "com.dvf.leaderboard");  }); 
                checkScoreboardButton.GetComponent<Button>().onClick.AddListener(() => {Social.ShowLeaderboardUI();  });
    }

    void ReportScore (long score, string leaderboardID) {
    Debug.Log ("Reporting score " + score + " on leaderboard " + leaderboardID);
    Social.ReportScore (score, leaderboardID, success => {
	Debug.Log(success ? "Reported score successfully" : "Failed to report score");
    });
}
}
