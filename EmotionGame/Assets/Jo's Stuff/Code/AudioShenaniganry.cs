using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class AudioShenaniganry : MonoBehaviour
{

    // Start is called before the first frame update
    public AudioSource vibes;
    public AudioSource vibent;

    void Start()
    {
        vibes = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            vibes.Play();
            vibent.Stop();
        }
    }
    

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            vibent.Play();
            vibes.Stop();
        }
    }
}


    