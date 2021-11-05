using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {

        if(other.CompareTag("Player"))
        {


            
            {
                Pause();
            }
        }
    }//OnCollisionEnter2DOnCollisionEnter2D


    void Pause()

    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    
    
}