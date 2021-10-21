using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenArea : MonoBehaviour
{
    public Animator anim;

    // Start is called before the first frame update

    void OnTriggerEnter2D(Collider2D cologne)
    {
        if (cologne.gameObject.tag == "Player")
        {
            anim.SetTrigger("player");
            anim.ResetTrigger("playerGone");
        }
    }

    private void OnTriggerExit2D(Collider2D cologne)
    {
        if (cologne.gameObject.tag == "Player")
        {
            anim.ResetTrigger("player");
            anim.SetTrigger("playerGone");
        }
    }
}