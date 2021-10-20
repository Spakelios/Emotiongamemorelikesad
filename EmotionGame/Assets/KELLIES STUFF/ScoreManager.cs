using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text text;
    private int score;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

    }
    public void ChangeScore(int enemyHit)
    {
        score += enemyHit;
        text.text = "SCORE: " + score.ToString();
    }
}