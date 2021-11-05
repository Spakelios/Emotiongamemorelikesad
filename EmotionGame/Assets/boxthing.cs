using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxthing : MonoBehaviour
{

    public GameObject theend;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            theend.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
