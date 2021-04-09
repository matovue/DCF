using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsBanner : MonoBehaviour

{
  //gameIDs for app store  4028740  for google play 4028741
    string gameId ="4028740";
    string placementId = "BanneriOS";
    bool testMode = true;


    // Start is called before the first frame update
    IEnumerator Start()
    {
      //gameIDs for app store  4028740  for google play 4028741
      Advertisement.Initialize(gameId, testMode);

      while (!Advertisement.IsReady())  
           yield return null;

      // Advertisement.Banner.Show(placementId); 
         Advertisement.Banner.SetPosition(BannerPosition.TOP_CENTER);   
         Advertisement.Banner.Show(placementId);  
    }

public void OnDestroy() {
 
        Advertisement.Banner.Hide();
       
}

}