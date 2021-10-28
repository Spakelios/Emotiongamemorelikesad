using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class Timer : MonoBehaviour
{  
    public GameObject YouDied;
    float currentTime = 100f;
    float startingTime = 0f;

   [SerializeField] Text countdownText;
   
    void Start()
    {
        currentTime = startingTime;
    }
    
    void Update()
    {
        currentTime += 1 * Time.deltaTime; // decreases by once per secound
        countdownText.text = currentTime.ToString();
    }
}

