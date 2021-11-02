using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.iOS;
using UnityEngine.UIElements;

public class DialogueManager : MonoBehaviour
{

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    public GameObject box;
    public  AudioSource TypeSound;


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
        TypeSound.Play();
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
        TypeSound.Stop();
    }

    void EndDialogue()
    {
        box.SetActive(false);
    }
}