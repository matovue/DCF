using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManaggger : MonoBehaviour
{
  public GameObject GameOverCanvas;

  public Text highscoreText; 

    void Start()
    {
        // to start game is not frozen
        GameOverCanvas.SetActive(false);
        Time.timeScale = 1;
       
    }

    public void GameOver()
    {
        //when character dies the GameOverCanvas is displayed and game is frozen
        GameOverCanvas.SetActive(true);
        Time.timeScale = 0;
         PlayerPrefs.SetFloat ("HighScore", Score.scoreValue);
        
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
         
           highscoreText.text = "HighScore : " + ((int)PlayerPrefs.GetFloat ("HighScore")).ToString() + "KB";  
      } 
    }
}