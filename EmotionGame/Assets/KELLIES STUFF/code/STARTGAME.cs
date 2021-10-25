using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class STARTGAME: MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Parallax test");
    }
}
