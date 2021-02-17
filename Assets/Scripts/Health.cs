using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int MaxHP;
    [HideInInspector]
    public int currentHP;

    private void Start()
    {
        currentHP = MaxHP;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Damage")
        {
            currentHP = currentHP - 1;
            Destroy(other.gameObject);
        }
    }
}
