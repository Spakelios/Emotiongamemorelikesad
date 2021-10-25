using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideButton : MonoBehaviour
{
  public GameObject Button;
  public GameObject box;

  private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                Button.SetActive(true);
                box.SetActive(true);
            }
        }

    }

