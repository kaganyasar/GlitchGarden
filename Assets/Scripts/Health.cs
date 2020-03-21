using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
    public float health = 100f;

    public void dealDamage(float damage)
    {
        health -= damage;
        if(health < 0)
        {
            destroyObject();
        }
    }
    public void destroyObject()
    {
        Destroy(gameObject);
    }
}
