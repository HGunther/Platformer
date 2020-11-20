using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController2D controller;
    public float runSpeed = 40f;

    float horizontalMove = 0f;
    
    
    void Update()
    {
        horizontalMove= Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate() {
        controller.Move(horizontalMove * runSpeed * Time.fixedDeltaTime, false, false);
    }
}
