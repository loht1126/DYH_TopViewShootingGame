using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float movespeed;

    void Update()
    {
        transform.Translate(transform.forward * movespeed * Time.deltaTime);
    }
}
