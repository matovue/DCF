using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

public class AdsManager : MonoBehaviour
{
    
    // Start is called before the first frame update
    
    IEnumerator Start()
    { 
       
      yield return new WaitForSeconds (10);  
      //gameIDs for app store  4028740  for google play 4028741
      Advertisement.Initialize("4028740", true);

      while (!Advertisement.IsReady())  
           yield return null;

       Advertisement.Show();    
        
    }


}