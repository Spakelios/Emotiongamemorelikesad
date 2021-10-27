using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class Timer : MonoBehaviour
{  
    public GameObject YouDied;
    float currentTime = 0f;
    float startingTime = 100f;

   [SerializeField] Text countdownText;
   
    void Start()
    {
        currentTime = startingTime;
        if (currentTime <= 0f)
        {
            YouDied.SetActive(true);
        }
    }
    
    void Update()
    {
        currentTime -= 1 * Time.deltaTime; // decreases by once per secound
        countdownText.text = currentTime.ToString();
        if (currentTime <= 0f)
        {
            YouDied.SetActive(true);
        }
    }
}

