using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;


public class Player : MonoBehaviour
{

    public Material HealthMat;
    public GameObject image;
    public AudioSource Chase;
    public AudioSource Safe;
    public AudioSource main;
   
    
    public float maxHealth;
    public float currentHealth;
    public float currentHealthmat = 0;
    public Vector3 respawnPoint;

 //   public HealthBar healthBar;

    private void Awake()
    {
        currentHealth = maxHealth;
        
        //healthBar.SetMaxHealth(maxHealth);
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

        if (currentHealth <= 5)

        {
            Respawn();
        }

        if (other.CompareTag("Health"))
        {
            RegainHealth(50);
        }
    }
    


    void Update()
    { Debug.Log(HealthMat.GetFloat("_health"));
        if (gameObject.CompareTag("Health"))
        { 
            RegainHealth(98);
        }
        HealthMat.SetFloat("_health", currentHealthmat);
        if (gameObject.CompareTag("Enemy"))
        {
          //  TakeDamage(1);

            
        }
        
        if (gameObject.CompareTag("Health"))
        {
            RegainHealth(50);
            
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        currentHealthmat += 0.1f;
        //  healthBar.SetHealth(currentHealth);


    }

    void Respawn()
    {
        transform.position = respawnPoint;
        currentHealth = maxHealth;
        currentHealthmat =0 ;
    }

    void RegainHealth(int healthincrease)
    {
        currentHealth += healthincrease;
        currentHealthmat -= 0.02f;
        //healthBar.SetHealth(currentHealth);
    }
}