using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // To change scenes in unity

public class GameOverExit : MonoBehaviour
{
 //function we will call whenever we press the play button

 

 public void ExitGame (){
SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
 }
}
