using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip typingSound;
    public static AudioClip errorSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        typingSound = Resources.Load<AudioClip>("Typingg");
        errorSound = Resources.Load<AudioClip>("ErrorSound");
        audioSrc = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

//A method called PlaySound that takes a string, the variable audioScr plays the audio added on the untiy inspector saved as Typingg  
    public static void PlaySound (string clip)
    {
        audioSrc.PlayOneShot(typingSound);
        
    }
//A method called PlaySound that takes a string, the variable audioScr plays the audio added on the untiy inspector saved as ErrorSound 
     public static void PlayError (string clipp)
    {
        audioSrc.PlayOneShot(errorSound);
        
    }
// A method that Stops the current sound playing using the unity Stop() method
     public static void StopSound()
    {
      
      audioSrc.Stop();
    }

}

