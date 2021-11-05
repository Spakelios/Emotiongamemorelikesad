using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.iOS;
using UnityEngine.UIElements;
using Image = UnityEngine.UIElements.Image;
using Random = UnityEngine.Random;

public class DialogueManager : MonoBehaviour
{
  
    public GameObject soundthinglol;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    public GameObject box;
    public AudioSource TypeSound;
    


    private Queue<string> sentences;

    // Use this for initialization
    void Start()
    {
        TypeSound = GetComponent<AudioSource>();
        sentences = new Queue<string>();
        
    }

    public void StartDialogue(Dialogue dialogue)
    {


        box.SetActive(true);


        nameText.text = dialogue.name;


        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {


            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();

    }

    //private void Update()
    // {
    //    _talk++;
    //   if(_talk >= Random.Range(120, 200))
    //  {
    // TypeSound = GetComponent<AudioSource>();
    // TypeSound.pitch = (Random.Range(0.1f, .9f));
    // TypeSound.Play();
    // _talk = 0;
    //    }
    //  }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
       
        //TypeSound.Play();
        
       
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {

            dialogueText.text += letter;
            Instantiate(soundthinglol);
           
            yield return null;
        }
    }






void EndDialogue()
    {
        box.SetActive(false);
    }
}