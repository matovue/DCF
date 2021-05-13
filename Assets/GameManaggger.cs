using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI; //add when refrencing text in unity 
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms;  
using System;
using System.Text;

public class GameManaggger : MonoBehaviour
{
  public GameObject GameOverCanvas;

  public Text highscoreText; //add (using UnityEngine.UI;) when refrencing text field in unity 
  
  public Text currentscoreText; //add (using UnityEngine.UI;) when refrencing text field in unity 

    public GameObject NeuHighScore;
    
    private AdsBanner AdBanner;

    public void Start()
    {
        // to start game is not frozen
        GameOverCanvas.SetActive(false);
        Time.timeScale = 1;
        GameOverCanvas.SetActive(false);
        
       if(this.enabled == null) {
        Debug.Log(AdBanner);
        AdBanner.OnDestroy();
        
        }
    }
    

    public void GameOver()
    {
        //when character dies the GameOverCanvas is displayed and game is frozen
        GameOverCanvas.SetActive(true);
        Time.timeScale = 0;
         
        // ***PlayerPrefs.SetFloat ("HighScore", Score.scoreValue);***
        // PlayerPrefs saves data, the value is saved in "HighScore" using SetFloat and Score.scoreValue is what you
        //are saving/setiing. You can then use PlayerPrefs.GetFloat to get the data saved in PlayerPrefs.SetFloat 
        //Below if the new value is greater than the value saved the new value is stored replacing the previous
        // if not it stays the same
        if (PlayerPrefs.GetFloat ("HighScore") < Score.scoreValue){
          PlayerPrefs.SetFloat ("HighScore", Score.scoreValue);
          NeuHighScore.SetActive(true);
          ReportScore(Score.scoreValue, "com.dvf.leaderboard");   
          
          
          
        }
          PlayerPrefs.SetFloat ("CurrentScore", Score.scoreValue);
      
        
         
        
    }
      void ReportScore (long score, string leaderboardID) {
    Debug.Log ("Reporting score " + score + " on leaderboard " + leaderboardID);
    Social.ReportScore (score, leaderboardID, success => {
	Debug.Log(success ? "Reported score successfully" : "Failed to report score");
    });
      }

    // Start is called before the first frame update
    
    //reloads the scence when player dies and clicks the (GameOverCanvas-> Image) button created in unity
    public void Replay()
    {
        SceneManager.LoadScene(0);
        
    }

    // Update is called once per frame
    void Update()
    {
     if (Time.timeScale==1){
          Score.scoreValue += 1;
          
     }
     else if(Time.timeScale==0)  
      {
          Score.scoreValue += 0;  
         // Displays the stored PlayerPrefs values
           highscoreText.text = " " + ((int)PlayerPrefs.GetFloat ("HighScore")).ToString() + " KB"; 
           currentscoreText.text = " " + ((int)PlayerPrefs.GetFloat ("CurrentScore")).ToString() + " KB"; 
           
      } 
    }
}