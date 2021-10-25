using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;
   

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("END SCREEN");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(10);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("Enemy"))
        {
            TakeDamage(10);
        }
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("END SCREEN");
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}