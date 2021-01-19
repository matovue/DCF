using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip typingSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        typingSound = Resources.Load<AudioClip>("Typingg");
        audioSrc = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        audioSrc.PlayOneShot(typingSound);
        
    }

     public static void StopSound()
    {
      
      audioSrc.Stop();
    }

}

