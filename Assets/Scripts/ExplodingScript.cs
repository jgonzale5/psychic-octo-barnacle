using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodingScript : MonoBehaviour
{
    public Transform explosionEffect;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Bump");
        if (other.gameObject.tag == "Damage")
        {
            Debug.Log("Boom");
            Instantiate(explosionEffect, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
