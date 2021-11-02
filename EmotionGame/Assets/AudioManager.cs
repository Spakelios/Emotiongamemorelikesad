using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

     public static AudioManager instance;

     private void Awake()
     {
          if(instance == null)
          {
               instance = this;
          }
          else
          {
               Destroy(instance);
          }
     }

     public AudioSource audioSource;

     public void PlayClip(AudioClip clip)
     {
          audioSource.PlayOneShot(clip); 
     }
}
