using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject player;
    public float movespeed;

    private void Start()
    {
        player = GameObject.Find("Player");
    }

    private void Update()
    {
        transform.LookAt(player.transform.position);
        transform.Translate(Vector3.forward * movespeed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
    }
}
