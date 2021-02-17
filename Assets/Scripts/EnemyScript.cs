using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{
    public NavMeshAgent pathfinding;
    public GameObject muzzle;
    public GameObject projectile;
    public GameObject eyes;
    public float visionRange;
    public bool pursuing = false;
    private GameObject target;
    
    void Update()
    {
        if (!pursuing)
        {
            //We create a ray coming from the eyes of the enemy, in the direction they're facing, that is as
            //long as its vision range
            Ray ray = new Ray(eyes.transform.position, eyes.transform.forward * visionRange);
            Debug.DrawRay(ray.origin, ray.direction, Color.red);

            RaycastHit hit;

            //We check if there are any objects in the ray coming from the enemy's eyes
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("I see something");
                //This enemy starts pursuing
                pursuing = true;
                //The object seen is marked as the target
                target = hit.transform.gameObject;
            }
        }
        else
        {
            pathfinding.SetDestination(target.transform.position);
        }
    }
}
