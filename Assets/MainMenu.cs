using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // To change scenes in unity

public class MainMenu : MonoBehaviour
{
 //function we will call whenever we press the play button

 public void PlayGame (){
// To change scenes in unity
// Loading next level 
// In unity we need to add scenes to the queue (file -> build settings -> then drag and drop scenes in the order you want them)
SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
 }

 
}
