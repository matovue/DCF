using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // To change scenes in unity
using UnityEngine.Advertisements;
public class GameOverExit : MonoBehaviour
{

 

 public void ExitGame (){
 SceneManager.LoadScene("Menu");
 // resets the score to zero
 Score.scoreValue = 0;

 
      //gameIDs for app store  4028740  for google play 4028741
      Advertisement.Initialize("4028740", true);

      if (Advertisement.IsReady())  
          {

       Advertisement.Show();  
 }


}
}
