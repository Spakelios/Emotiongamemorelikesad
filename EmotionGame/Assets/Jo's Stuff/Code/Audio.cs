using System.Collections;
using System.Collections.Generic;
using System.Net.Mail;
using UnityEngine;


public class Audio : MonoBehaviour
{

    // Start is called before the first frame update
    public AudioSource vibes;
    public AudioSource safety;

    void Start()
    {
        vibes = GetComponent<AudioSource>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            safety.Play();
            vibes.Stop();
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            vibes.Play();
        }
    }


}
