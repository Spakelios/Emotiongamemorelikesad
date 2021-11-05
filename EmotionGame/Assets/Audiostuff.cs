using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;
using Random = UnityEngine.Random;

public class Audiostuff : MonoBehaviour
{
    public AudioSource sound;
    private int death = 0;
    void Start()
    {
        sound = GetComponent<AudioSource>();
        sound.pitch = (Random.Range(0.1f, .9f));
        sound.Play();
    }

    private void Update()
    {
        death++;
        if (death == 30)
        {
            Destroy(gameObject);
        }
    }
}
