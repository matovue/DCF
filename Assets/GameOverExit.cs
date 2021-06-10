using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // To change scenes in unity

public class GameOverExit : MonoBehaviour
{

 

 public void ExitGame (){
 SceneManager.LoadScene("Menu");
 // resets the score to zero
 Score.scoreValue = 0;
 }
}
