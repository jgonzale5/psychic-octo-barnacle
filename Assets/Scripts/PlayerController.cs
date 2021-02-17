﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public CharacterController controller;

    // Update is called once per frame
    void Update()
    {
        float movX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float movZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float gravity = Physics.gravity.y * Time.deltaTime;
        Vector3 movementVector = new Vector3(movX, gravity, movZ);

        controller.Move(movementVector);

        //(1, 0, 0) Vector3.right
        //(0, 1, 0) Vector3.up
        //(0, 0, 1) Vector3.forward

        //transform.right will get you what the right side of the object is pointing at
        //transform.up will get you what the top of the object is pointing at
        //transform.forward will get you what the front of the object is pointing at

    }
}
