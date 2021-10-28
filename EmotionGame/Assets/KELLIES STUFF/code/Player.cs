using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    
    public int maxHealth;
    public int currentHealth;
    public Vector3 respawnPoint;

    public HealthBar healthBar;

    private void Awake()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(25);
        }

        if (other.gameObject.CompareTag("Checkpoint"))
        {
            respawnPoint = other.transform.position;
        }

        if (currentHealth <= 5)

        {
            Respawn();
        }
    }


    void Update()
    {
        if (gameObject.CompareTag("Enemy"))
        {
            TakeDamage(10);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);

    }

    void Respawn()
    {
        transform.position = respawnPoint;
         regen();
    }

    void regen()
    {
        currentHealth = maxHealth;
    }
}