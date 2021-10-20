using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    public int enemyHit = 1;
    
    private void OnTriggerEnter2D(Collider2D other)

    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            ScoreManager.instance.ChangeScore(enemyHit);
        }
    }
}
