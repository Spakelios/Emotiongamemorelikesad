using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellCollision : MonoBehaviour
{
    public GameObject CellChild;




    private void OnTriggerEnter2D(Collider2D Col)
    {
        if (Col.gameObject.CompareTag("Player"))
        {
            Debug.Log("fartin");
            CellChild.GetComponent<RotateToTarget>().chase = true;
        }

    }

    private void OnTriggerExit2D(Collider2D Col)
    {
        if (Col.gameObject.CompareTag("Player"))
        {
            Debug.Log("Shitin");
            CellChild.GetComponent<RotateToTarget>().chase = false;
        }

    }

}

