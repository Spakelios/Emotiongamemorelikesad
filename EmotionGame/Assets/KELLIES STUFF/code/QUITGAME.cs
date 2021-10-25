using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QUITGAME : MonoBehaviour
{
  public void quit()
  {
    Application.Quit();
    Debug.Log("Game is closing"); 
  }
}

