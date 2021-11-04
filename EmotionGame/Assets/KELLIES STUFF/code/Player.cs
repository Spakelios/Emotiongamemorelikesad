using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{

    public Material HealthMat;
    
    public int maxHealth;
    public int currentHealth;
    public Vector3 respawnPoint;

    public HealthBar healthBar;

    private void Awake()
    {
        currentHealth = maxHealth;
        HealthMat.SetFloat("_health",0);
        healthBar.SetMaxHealth(maxHealth);
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
    {
        if (gameObject.CompareTag("Enemy"))
        {
            TakeDamage(10);
            
        }
        
        if (gameObject.CompareTag("Health"))
        {
            RegainHealth(50);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
        HealthMat.SetFloat("_health", +1);

    }

    void Respawn()
    {
        transform.position = respawnPoint;
        currentHealth = maxHealth;
    }

    void RegainHealth(int healthincrease)
    {
        currentHealth += healthincrease;
        
        healthBar.SetHealth(currentHealth);
    }
}