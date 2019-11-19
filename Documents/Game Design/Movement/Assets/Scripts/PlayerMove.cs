using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public CharacterController2D controller;

    public float runSpeed = 40f;
    public float sprintSpeed = 70f;
    float horizontalMove = 0f;

    bool jump = false;
    bool crouch = false;
    bool sprint = false;
    // Start is called before the first frame update

    void Update()
    {

        //Moves the Character
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        //Makes the character Jump
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        //Makes the character Crouch
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
            crouch = false;

        //Makes the Character Run
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            sprint = true;

        } else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            sprint = false;
        }
    }

    void FixedUpdate()
    {
        //Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;

       

        
    }
}
