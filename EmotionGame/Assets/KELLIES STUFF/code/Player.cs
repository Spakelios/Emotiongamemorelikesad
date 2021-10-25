using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;
    public GameObject YouDied;
    public Vector3 respawnPoint;

    public HealthBar healthBar;
    
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        if (currentHealth <= 0)
        {
            transform.position = respawnPoint;
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(10);
        }

        if (other.gameObject.CompareTag("Checkpoint"))
        {
            respawnPoint = other.transform.position;
        }
    }
    //  if (currentHealth <= 0)

        //{
       //     Pause();
      //  }
    

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("Enemy"))
        {
            TakeDamage(10);
        }
        if (currentHealth <= 0)
        {
            transform.position = respawnPoint;
        }
     //   if (currentHealth <= 0)

     //   {
      //      Pause();
      //  }
        
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
    
   // void Pause()

    //{
    //    YouDied.SetActive(true);
     //   Time.timeScale = 0f;
   // }


}