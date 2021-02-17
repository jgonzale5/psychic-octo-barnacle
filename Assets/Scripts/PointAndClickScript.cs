using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PointAndClickScript : MonoBehaviour
{
    public NavMeshAgent player;
    public Transform hitObject;
    public ParticleSystem hitObjectSystem;
    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.Log(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                hitObject.position = hit.point;
                hitObject.up = hit.normal;
                hitObjectSystem.Play();

                player.destination = hit.point;
            }
        }
    }
}
