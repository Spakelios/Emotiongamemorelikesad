using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalPlatform : MonoBehaviour
{
    private PlatformEffector2D effector;

    public float waitTime;
    bool crouch = false;
    // Start is called before the first frame update
    void Start()
    {
        effector = GetComponent<PlatformEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.S))
        {
            crouch = true;
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            crouch = false;
        }

        if (waitTime > 0)
        {
            waitTime -= 0.005f;
        }
      

        if (crouch == true) {
            {
                if (Input.GetKey(KeyCode.LeftControl)) { 
                   
                        effector.rotationalOffset = 180f;
                        waitTime = 0.5f;
                    }
                   
                                                   }
        }

        if (waitTime <0||Input.GetKeyDown(KeyCode.Space))
        {
            effector.rotationalOffset = 0;
        }
    }
}