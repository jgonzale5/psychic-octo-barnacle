﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    //[HideInInspector]
    [Range(0, Mathf.Infinity)]
    public float Speed;
    [SerializeField]
    private GameObject Bob;
    public KeyCode killKey;
    public string movementAxis = "Horizontal";

    private void Start()
    {
        //Debug.Log("Object Start");

        //Does the same thing as ^
        print("Object Start");
    }

    private void Awake()
    {
        Debug.Log("Object Awake");
    }

    private void FixedUpdate()
    {
        
    }

    public void Update()
    {
        float axis = Input.GetAxis(movementAxis);

        
        Bob.transform.Translate(new Vector2(axis * Speed * Time.deltaTime, 0));


        if (Input.GetKey(killKey))
        {
            Kill(this.gameObject);
        }
    }

    private void OnEnable()
    {
        print("Object Enabled");
    }

    private void OnDisable()
    {
        print("Object Disabled");
    }

    private void OnDestroy()
    {
        print("Object Destroyed");
    }

    private void OnGUI()
    {
        
    }

    public void Kill(GameObject objectToKill)
    {
        Destroy(objectToKill);
    }


}
