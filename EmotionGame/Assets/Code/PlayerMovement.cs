using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public Animator animator;

    float horizontalMove = 0f;

    public Rigidbody2D rb;

    public float runspeed = 40f;

    float verticalMove;

    bool jump = false;

    bool crouch = false;

   
    // Update is called once per frame
    void Update()
    {

        verticalMove = rb.velocity.y;
        

        horizontalMove = Input.GetAxisRaw("Horizontal") * runspeed;


        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        //verticalMove = Input.GetAxisRaw("Vertical");

        animator.SetFloat("VertSpeed", verticalMove);

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            
            animator.SetBool("Jump", true);
        }

        if(Input.GetButtonDown("Crouch"))
        {
            animator.SetBool("Crouch", true);
            crouch = true;
        } else if (Input.GetButtonUp("Crouch"))
        {
            animator.SetBool("Crouch", false);
            crouch = false;
        }


    }

    private void FixedUpdate()
    {
        //movement for character im gonna actually vomit.
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
        animator.SetBool("Jump",false);

    }
}
