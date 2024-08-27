using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float movespeed;


    private void Start()
    {
        Invoke("killmyself", 3.0f);
    }
    void Update()
    {
        transform.Translate(Vector3.forward * movespeed * Time.deltaTime);
    }


    private void killmyself()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemy"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
